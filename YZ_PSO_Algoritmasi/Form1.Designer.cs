namespace YZ_PSO_Algoritmasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numericUpDown_parcacik_sayisi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_jenerasyon_sayisi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_c1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_c2 = new System.Windows.Forms.NumericUpDown();
            this.button_start = new System.Windows.Forms.Button();
            this.label_en_iyi_cozum = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_amac_fonksiyonu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_parcacik_sayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_jenerasyon_sayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_parcacik_sayisi
            // 
            this.numericUpDown_parcacik_sayisi.Location = new System.Drawing.Point(12, 493);
            this.numericUpDown_parcacik_sayisi.Name = "numericUpDown_parcacik_sayisi";
            this.numericUpDown_parcacik_sayisi.Size = new System.Drawing.Size(175, 22);
            this.numericUpDown_parcacik_sayisi.TabIndex = 0;
            // 
            // numericUpDown_jenerasyon_sayisi
            // 
            this.numericUpDown_jenerasyon_sayisi.Location = new System.Drawing.Point(193, 494);
            this.numericUpDown_jenerasyon_sayisi.Name = "numericUpDown_jenerasyon_sayisi";
            this.numericUpDown_jenerasyon_sayisi.Size = new System.Drawing.Size(179, 22);
            this.numericUpDown_jenerasyon_sayisi.TabIndex = 1;
            // 
            // numericUpDown_c1
            // 
            this.numericUpDown_c1.Location = new System.Drawing.Point(378, 493);
            this.numericUpDown_c1.Name = "numericUpDown_c1";
            this.numericUpDown_c1.Size = new System.Drawing.Size(193, 22);
            this.numericUpDown_c1.TabIndex = 3;
            // 
            // numericUpDown_c2
            // 
            this.numericUpDown_c2.Location = new System.Drawing.Point(577, 493);
            this.numericUpDown_c2.Name = "numericUpDown_c2";
            this.numericUpDown_c2.Size = new System.Drawing.Size(166, 22);
            this.numericUpDown_c2.TabIndex = 4;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(782, 493);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(94, 23);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Başlat";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_en_iyi_cozum
            // 
            this.label_en_iyi_cozum.Location = new System.Drawing.Point(768, 49);
            this.label_en_iyi_cozum.Name = "label_en_iyi_cozum";
            this.label_en_iyi_cozum.Size = new System.Drawing.Size(113, 36);
            this.label_en_iyi_cozum.TabIndex = 6;
            this.label_en_iyi_cozum.Text = "En İyi Çözüm";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 49);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(731, 372);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label_amac_fonksiyonu
            // 
            this.label_amac_fonksiyonu.Location = new System.Drawing.Point(768, 103);
            this.label_amac_fonksiyonu.Name = "label_amac_fonksiyonu";
            this.label_amac_fonksiyonu.Size = new System.Drawing.Size(108, 36);
            this.label_amac_fonksiyonu.TabIndex = 8;
            this.label_amac_fonksiyonu.Text = "Amaç Fonksiyonu";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Parçacık Sayısı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(193, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Jenerasyon Sayısı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(375, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "C1 Değeri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(574, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "C2 Değeri";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(731, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yakınsama Grafiği";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 527);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label_amac_fonksiyonu);
            this.Controls.Add(this.label_en_iyi_cozum);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.numericUpDown_c2);
            this.Controls.Add(this.numericUpDown_c1);
            this.Controls.Add(this.numericUpDown_jenerasyon_sayisi);
            this.Controls.Add(this.numericUpDown_parcacik_sayisi);
            this.Name = "Form1";
            this.Text = "PSO Algoritması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_parcacik_sayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_jenerasyon_sayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_parcacik_sayisi;
        private System.Windows.Forms.NumericUpDown numericUpDown_jenerasyon_sayisi;
        private System.Windows.Forms.NumericUpDown numericUpDown_c1;
        private System.Windows.Forms.NumericUpDown numericUpDown_c2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_en_iyi_cozum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_amac_fonksiyonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
