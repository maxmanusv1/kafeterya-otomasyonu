namespace KafeteryaOtomasyonu
{
    partial class SepetUrun
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.UrunIsmi = new System.Windows.Forms.Label();
            this.adet = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.ucret = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrunIsmi
            // 
            this.UrunIsmi.AutoSize = true;
            this.UrunIsmi.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunIsmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.UrunIsmi.Location = new System.Drawing.Point(15, 12);
            this.UrunIsmi.Name = "UrunIsmi";
            this.UrunIsmi.Size = new System.Drawing.Size(72, 20);
            this.UrunIsmi.TabIndex = 4;
            this.UrunIsmi.Text = "UrunIsmi";
            // 
            // adet
            // 
            this.adet.AutoSize = true;
            this.adet.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.adet.Location = new System.Drawing.Point(134, 12);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(18, 20);
            this.adet.TabIndex = 5;
            this.adet.Text = "2";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.label.Location = new System.Drawing.Point(111, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(17, 20);
            this.label.TabIndex = 6;
            this.label.Text = "x";
            // 
            // ucret
            // 
            this.ucret.AutoSize = true;
            this.ucret.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.ucret.Location = new System.Drawing.Point(179, 12);
            this.ucret.Name = "ucret";
            this.ucret.Size = new System.Drawing.Size(52, 20);
            this.ucret.TabIndex = 7;
            this.ucret.Text = "label1";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SepetUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucret);
            this.Controls.Add(this.label);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.UrunIsmi);
            this.Name = "SepetUrun";
            this.Size = new System.Drawing.Size(254, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label UrunIsmi;
        public System.Windows.Forms.Label adet;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.Label ucret;
        public System.Windows.Forms.Button button1;
    }
}
