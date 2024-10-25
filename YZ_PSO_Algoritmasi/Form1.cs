using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YZ_PSO_Algoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Varsayılan değerler atanıyor
            numericUpDown_parcacik_sayisi.Value = 30; // Örneğin, 30 parçacık
            numericUpDown_jenerasyon_sayisi.Value = 100; // Örneğin, 100 jenerasyon
            numericUpDown_c1.Value = 1.5m; // Örneğin, C1 = 1.5
            numericUpDown_c2.Value = 1.5m; // Örneğin, C2 = 1.5

            // Grafik ayarları
            chart1.Series.Clear();
            Series series = new Series
            {
                Name = "Hata",
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2
            };
            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Jenerasyon";
            chart1.ChartAreas[0].AxisY.Title = "Amaç Fonksiyonu";
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "F6";
            chart1.Titles.Add("");
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan değerler
            int parcacikSayisi = (int)numericUpDown_parcacik_sayisi.Value;
            int jenerasyonSayisi = (int)numericUpDown_jenerasyon_sayisi.Value;
            double c1 = (double)numericUpDown_c1.Value;
            double c2 = (double)numericUpDown_c2.Value;

            // PSO nesnesi oluşturuluyor ve optimize ediliyor
            PSO pso = new PSO(parcacikSayisi, jenerasyonSayisi, c1, c2);
            pso.Optimize(3, AmacFonksiyonu); // Örnek olarak 3 boyutlu

            // En iyi çözüm ve hata değeri ekrana yazdırılıyor
            double[] enIyiKonum = pso.EnIyiKonum;
            double enIyiHata = pso.EnIyiHata;

            label_en_iyi_cozum.Text = $"En İyi Konum: {string.Join(", ", enIyiKonum)}";
            label_amac_fonksiyonu.Text = $"En İyi Hata: {enIyiHata}";

            // Yakınsama grafiğini çizdirme
            var hatalar = pso.Hatalar;
            chart1.Series["Hata"].Points.Clear();
            for (int i = 0; i < hatalar.Count; i++)
            {
                chart1.Series["Hata"].Points.AddXY(i, hatalar[i]);
            }
        }

        // Amaç fonksiyonu
        public double AmacFonksiyonu(double[] x)
        {
            double toplam = 0.0;
            for (int i = 0; i < x.Length - 1; i++)
            {
                double kisim1 = 100 * Math.Pow(x[i + 1] - x[i] * x[i], 2);
                double kisim2 = Math.Pow(x[i] - 1, 2);
                toplam += kisim1 + kisim2;
            }
            return toplam;
        }
    }

    public class Parcacik
    {
        public double[] Konum { get; set; }
        public double[] Hiz { get; set; }
        public double[] EnIyiKonum { get; set; }
        public double EnIyiHata { get; set; } = double.MaxValue;

        public Parcacik(int boyut)
        {
            Konum = new double[boyut];
            Hiz = new double[boyut];
            EnIyiKonum = new double[boyut];
        }
    }

    public class PSO
    {
        private int _parcacikSayisi;
        private int _jenerasyonSayisi;
        private double _c1;
        private double _c2;
        private double _w = 0.5; // eylemsizlik ağırlığı
        private double _wMin = 0.4;
        private double _wMax = 0.9;
        private Random _rastgele = new Random();

        public double[] EnIyiKonum { get; private set; }
        public double EnIyiHata { get; private set; } = double.MaxValue;
        private List<double> _hatalar = new List<double>();

        public PSO(int parcacikSayisi, int jenerasyonSayisi, double c1, double c2)
        {
            _parcacikSayisi = parcacikSayisi;
            _jenerasyonSayisi = jenerasyonSayisi;
            _c1 = c1;
            _c2 = c2;
        }

        public void Optimize(int boyut, Func<double[], double> amacFonksiyonu)
        {
            List<Parcacik> parcaciklar = ParcaciklariBaslat(boyut);

            for (int i = 0; i < _jenerasyonSayisi; i++)
            {
                foreach (var parcacik in parcaciklar)
                {
                    double hata = amacFonksiyonu(parcacik.Konum);

                    if (hata < parcacik.EnIyiHata)
                    {
                        parcacik.EnIyiHata = hata;
                        parcacik.EnIyiKonum = (double[])parcacik.Konum.Clone();
                    }

                    if (hata < EnIyiHata)
                    {
                        EnIyiHata = hata;
                        EnIyiKonum = (double[])parcacik.Konum.Clone();
                    }
                }

                // Hız ve konum güncellenmesi
                foreach (var parcacik in parcaciklar)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        double r1 = _rastgele.NextDouble();
                        double r2 = _rastgele.NextDouble();

                        parcacik.Hiz[j] = _w * parcacik.Hiz[j] +
                                           _c1 * r1 * (parcacik.EnIyiKonum[j] - parcacik.Konum[j]) +
                                           _c2 * r2 * (EnIyiKonum[j] - parcacik.Konum[j]);

                        parcacik.Konum[j] += parcacik.Hiz[j];
                    }
                }

                // Hata değeri güncelleniyor
                _hatalar.Add(EnIyiHata);
                _w = _wMax - ((double)i / _jenerasyonSayisi) * (_wMax - _wMin);
            }
        }

        // Parçacıkları başlatma
        private List<Parcacik> ParcaciklariBaslat(int boyut)
        {
            List<Parcacik> parcaciklar = new List<Parcacik>();

            for (int i = 0; i < _parcacikSayisi; i++)
            {
                Parcacik parcacik = new Parcacik(boyut);
                for (int j = 0; j < boyut; j++)
                {
                    parcacik.Konum[j] = _rastgele.NextDouble() * 10 - 5; // aralık [-5, 5]
                    parcacik.Hiz[j] = _rastgele.NextDouble() * 2 - 1;  // aralık [-1, 1]
                }
                parcaciklar.Add(parcacik);
            }

            return parcaciklar;
        }

        // Hataları geri döndürme
        public List<double> Hatalar
        {
            get { return _hatalar; }
        }
    }
}
