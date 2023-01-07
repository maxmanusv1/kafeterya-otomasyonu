namespace KafeteryaOtomasyonu
{
    partial class UrunEkle
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
            this.urunFiyat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.urunKategori = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sepeteEkleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UrunIsmi
            // 
            this.UrunIsmi.AutoSize = true;
            this.UrunIsmi.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunIsmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.UrunIsmi.Location = new System.Drawing.Point(13, 11);
            this.UrunIsmi.Name = "UrunIsmi";
            this.UrunIsmi.Size = new System.Drawing.Size(72, 20);
            this.UrunIsmi.TabIndex = 3;
            this.UrunIsmi.Text = "UrunIsmi";
            // 
            // urunFiyat
            // 
            this.urunFiyat.AutoSize = true;
            this.urunFiyat.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.urunFiyat.Location = new System.Drawing.Point(330, 12);
            this.urunFiyat.Name = "urunFiyat";
            this.urunFiyat.Size = new System.Drawing.Size(44, 20);
            this.urunFiyat.TabIndex = 4;
            this.urunFiyat.Text = "19TL";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Mulish SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(485, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(49, 40);
            this.textBox1.TabIndex = 5;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // urunKategori
            // 
            this.urunKategori.AutoSize = true;
            this.urunKategori.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.urunKategori.Location = new System.Drawing.Point(172, 12);
            this.urunKategori.Name = "urunKategori";
            this.urunKategori.Size = new System.Drawing.Size(69, 20);
            this.urunKategori.TabIndex = 6;
            this.urunKategori.Text = "Kategori";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mulish Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(448, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Mulish Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(540, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sepeteEkleBtn
            // 
            this.sepeteEkleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sepeteEkleBtn.FlatAppearance.BorderSize = 0;
            this.sepeteEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sepeteEkleBtn.Font = new System.Drawing.Font("Mulish Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sepeteEkleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.sepeteEkleBtn.Location = new System.Drawing.Point(602, 5);
            this.sepeteEkleBtn.Name = "sepeteEkleBtn";
            this.sepeteEkleBtn.Size = new System.Drawing.Size(112, 34);
            this.sepeteEkleBtn.TabIndex = 9;
            this.sepeteEkleBtn.Text = "Sepete Ekle";
            this.sepeteEkleBtn.UseVisualStyleBackColor = false;
            this.sepeteEkleBtn.Click += new System.EventHandler(this.sepeteEkleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mulish SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(380, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "TL";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sepeteEkleBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urunKategori);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.urunFiyat);
            this.Controls.Add(this.UrunIsmi);
            this.Name = "UrunEkle";
            this.Size = new System.Drawing.Size(877, 46);
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label UrunIsmi;
        public System.Windows.Forms.Label urunFiyat;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label urunKategori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sepeteEkleBtn;
        public System.Windows.Forms.Label label1;
    }
}
