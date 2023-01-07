namespace KafeteryaOtomasyonu
{
    partial class UrunListele
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
            this.Kategori = new System.Windows.Forms.Label();
            this.Adet = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.Label();
            this.SatilanAdet = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrunIsmi
            // 
            this.UrunIsmi.AutoSize = true;
            this.UrunIsmi.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunIsmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.UrunIsmi.Location = new System.Drawing.Point(44, 12);
            this.UrunIsmi.Name = "UrunIsmi";
            this.UrunIsmi.Size = new System.Drawing.Size(69, 20);
            this.UrunIsmi.TabIndex = 2;
            this.UrunIsmi.Text = "Masa 13";
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.Kategori.Location = new System.Drawing.Point(239, 12);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(69, 20);
            this.Kategori.TabIndex = 3;
            this.Kategori.Text = "Masa 13";
            // 
            // Adet
            // 
            this.Adet.AutoSize = true;
            this.Adet.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.Adet.Location = new System.Drawing.Point(418, 12);
            this.Adet.Name = "Adet";
            this.Adet.Size = new System.Drawing.Size(69, 20);
            this.Adet.TabIndex = 4;
            this.Adet.Text = "Masa 13";
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Fiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.Fiyat.Location = new System.Drawing.Point(560, 12);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(69, 20);
            this.Fiyat.TabIndex = 5;
            this.Fiyat.Text = "Masa 13";
            // 
            // SatilanAdet
            // 
            this.SatilanAdet.AutoSize = true;
            this.SatilanAdet.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SatilanAdet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.SatilanAdet.Location = new System.Drawing.Point(733, 12);
            this.SatilanAdet.Name = "SatilanAdet";
            this.SatilanAdet.Size = new System.Drawing.Size(69, 20);
            this.SatilanAdet.TabIndex = 6;
            this.SatilanAdet.Text = "Masa 13";
            // 
            // btn
            // 
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.btn.Location = new System.Drawing.Point(849, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(110, 49);
            this.btn.TabIndex = 7;
            this.btn.Text = "Düzenle";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // UrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn);
            this.Controls.Add(this.SatilanAdet);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.Adet);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.UrunIsmi);
            this.Name = "UrunListele";
            this.Size = new System.Drawing.Size(1119, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label UrunIsmi;
        public System.Windows.Forms.Label Kategori;
        public System.Windows.Forms.Label Adet;
        public System.Windows.Forms.Label Fiyat;
        public System.Windows.Forms.Label SatilanAdet;
        private System.Windows.Forms.Button btn;
    }
}
