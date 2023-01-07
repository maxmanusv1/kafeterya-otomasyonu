namespace KafeteryaOtomasyonu
{
    partial class SiparislerUserControl
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
            this.MasaLabel = new System.Windows.Forms.Label();
            this.PersonelLabel = new System.Windows.Forms.Label();
            this.TarihLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MasaLabel
            // 
            this.MasaLabel.AutoSize = true;
            this.MasaLabel.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MasaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.MasaLabel.Location = new System.Drawing.Point(110, 12);
            this.MasaLabel.Name = "MasaLabel";
            this.MasaLabel.Size = new System.Drawing.Size(69, 20);
            this.MasaLabel.TabIndex = 0;
            this.MasaLabel.Text = "Masa 13";
            // 
            // PersonelLabel
            // 
            this.PersonelLabel.AutoSize = true;
            this.PersonelLabel.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.PersonelLabel.Location = new System.Drawing.Point(456, 12);
            this.PersonelLabel.Name = "PersonelLabel";
            this.PersonelLabel.Size = new System.Drawing.Size(82, 20);
            this.PersonelLabel.TabIndex = 1;
            this.PersonelLabel.Text = "Personel 2";
            // 
            // TarihLabel
            // 
            this.TarihLabel.AutoSize = true;
            this.TarihLabel.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.TarihLabel.Location = new System.Drawing.Point(752, 12);
            this.TarihLabel.Name = "TarihLabel";
            this.TarihLabel.Size = new System.Drawing.Size(87, 20);
            this.TarihLabel.TabIndex = 2;
            this.TarihLabel.Text = "19.12.2022";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1095, 2);
            this.panel3.TabIndex = 3;
            // 
            // SiparislerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TarihLabel);
            this.Controls.Add(this.PersonelLabel);
            this.Controls.Add(this.MasaLabel);
            this.Font = new System.Drawing.Font("Mulish", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SiparislerUserControl";
            this.Size = new System.Drawing.Size(1095, 45);
            this.Load += new System.EventHandler(this.SiparislerUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label MasaLabel;
        public System.Windows.Forms.Label PersonelLabel;
        public System.Windows.Forms.Label TarihLabel;
        private System.Windows.Forms.Panel panel3;
    }
}
