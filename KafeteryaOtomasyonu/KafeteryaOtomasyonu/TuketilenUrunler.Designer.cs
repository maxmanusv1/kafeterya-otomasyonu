namespace KafeteryaOtomasyonu
{
    partial class TuketilenUrunler
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
            this.UrunIsmiLabel = new System.Windows.Forms.Label();
            this.AdetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UrunIsmiLabel
            // 
            this.UrunIsmiLabel.AutoSize = true;
            this.UrunIsmiLabel.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunIsmiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.UrunIsmiLabel.Location = new System.Drawing.Point(43, 10);
            this.UrunIsmiLabel.Name = "UrunIsmiLabel";
            this.UrunIsmiLabel.Size = new System.Drawing.Size(75, 20);
            this.UrunIsmiLabel.TabIndex = 1;
            this.UrunIsmiLabel.Text = "Urun Ismi";
            // 
            // AdetLabel
            // 
            this.AdetLabel.AutoSize = true;
            this.AdetLabel.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.AdetLabel.Location = new System.Drawing.Point(332, 10);
            this.AdetLabel.Name = "AdetLabel";
            this.AdetLabel.Size = new System.Drawing.Size(42, 20);
            this.AdetLabel.TabIndex = 2;
            this.AdetLabel.Text = "Adet";
            // 
            // TuketilenUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdetLabel);
            this.Controls.Add(this.UrunIsmiLabel);
            this.Name = "TuketilenUrunler";
            this.Size = new System.Drawing.Size(449, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label UrunIsmiLabel;
        public System.Windows.Forms.Label AdetLabel;
    }
}
