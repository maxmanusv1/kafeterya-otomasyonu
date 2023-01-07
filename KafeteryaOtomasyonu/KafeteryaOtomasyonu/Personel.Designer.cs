namespace KafeteryaOtomasyonu
{
    partial class Personel
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
            this.PersonelIsmi = new System.Windows.Forms.Label();
            this.soyadiLabel = new System.Windows.Forms.Label();
            this.calismaLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PersonelIsmi
            // 
            this.PersonelIsmi.AutoSize = true;
            this.PersonelIsmi.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelIsmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.PersonelIsmi.Location = new System.Drawing.Point(76, 11);
            this.PersonelIsmi.Name = "PersonelIsmi";
            this.PersonelIsmi.Size = new System.Drawing.Size(46, 20);
            this.PersonelIsmi.TabIndex = 3;
            this.PersonelIsmi.Text = "pismi";
            // 
            // soyadiLabel
            // 
            this.soyadiLabel.AutoSize = true;
            this.soyadiLabel.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.soyadiLabel.Location = new System.Drawing.Point(279, 11);
            this.soyadiLabel.Name = "soyadiLabel";
            this.soyadiLabel.Size = new System.Drawing.Size(55, 20);
            this.soyadiLabel.TabIndex = 4;
            this.soyadiLabel.Text = "soyadi";
            // 
            // calismaLabel
            // 
            this.calismaLabel.AutoSize = true;
            this.calismaLabel.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calismaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.calismaLabel.Location = new System.Drawing.Point(507, 11);
            this.calismaLabel.Name = "calismaLabel";
            this.calismaLabel.Size = new System.Drawing.Size(101, 20);
            this.calismaLabel.TabIndex = 5;
            this.calismaLabel.Text = "calismasayisi";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(694, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 20);
            this.panel1.TabIndex = 6;
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calismaLabel);
            this.Controls.Add(this.soyadiLabel);
            this.Controls.Add(this.PersonelIsmi);
            this.Name = "Personel";
            this.Size = new System.Drawing.Size(1118, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label PersonelIsmi;
        public System.Windows.Forms.Label soyadiLabel;
        public System.Windows.Forms.Label calismaLabel;
        public System.Windows.Forms.Panel panel1;
    }
}
