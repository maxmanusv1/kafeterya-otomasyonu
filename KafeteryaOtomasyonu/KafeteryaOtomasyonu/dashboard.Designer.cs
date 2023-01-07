namespace KafeteryaOtomasyonu
{
    partial class dashboard
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.FormsPanel = new System.Windows.Forms.Panel();
            this.leftsidepanel = new System.Windows.Forms.Panel();
            this.siparisbtn = new System.Windows.Forms.Button();
            this.masalarbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VerilerBtn = new System.Windows.Forms.Button();
            this.PersonellerBtn = new System.Windows.Forms.Button();
            this.UrunlerBtn = new System.Windows.Forms.Button();
            this.SiparislerBtn = new System.Windows.Forms.Button();
            this.GozAtBtn = new System.Windows.Forms.Button();
            this.logopanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundPanel.SuspendLayout();
            this.leftsidepanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.backgroundPanel.Controls.Add(this.FormsPanel);
            this.backgroundPanel.Controls.Add(this.leftsidepanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1366, 768);
            this.backgroundPanel.TabIndex = 0;
            // 
            // FormsPanel
            // 
            this.FormsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormsPanel.Location = new System.Drawing.Point(247, 0);
            this.FormsPanel.Name = "FormsPanel";
            this.FormsPanel.Size = new System.Drawing.Size(1119, 768);
            this.FormsPanel.TabIndex = 6;
            // 
            // leftsidepanel
            // 
            this.leftsidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.leftsidepanel.Controls.Add(this.siparisbtn);
            this.leftsidepanel.Controls.Add(this.masalarbtn);
            this.leftsidepanel.Controls.Add(this.panel2);
            this.leftsidepanel.Controls.Add(this.VerilerBtn);
            this.leftsidepanel.Controls.Add(this.PersonellerBtn);
            this.leftsidepanel.Controls.Add(this.UrunlerBtn);
            this.leftsidepanel.Controls.Add(this.SiparislerBtn);
            this.leftsidepanel.Controls.Add(this.GozAtBtn);
            this.leftsidepanel.Controls.Add(this.logopanel);
            this.leftsidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftsidepanel.Location = new System.Drawing.Point(0, 0);
            this.leftsidepanel.Name = "leftsidepanel";
            this.leftsidepanel.Size = new System.Drawing.Size(247, 768);
            this.leftsidepanel.TabIndex = 0;
            // 
            // siparisbtn
            // 
            this.siparisbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.siparisbtn.FlatAppearance.BorderSize = 0;
            this.siparisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siparisbtn.Font = new System.Drawing.Font("Mulish Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.siparisbtn.Location = new System.Drawing.Point(0, 462);
            this.siparisbtn.Name = "siparisbtn";
            this.siparisbtn.Size = new System.Drawing.Size(247, 56);
            this.siparisbtn.TabIndex = 7;
            this.siparisbtn.Text = "Siparis Hazırla";
            this.siparisbtn.UseVisualStyleBackColor = true;
            this.siparisbtn.Click += new System.EventHandler(this.siparisbtn_Click);
            // 
            // masalarbtn
            // 
            this.masalarbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.masalarbtn.FlatAppearance.BorderSize = 0;
            this.masalarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masalarbtn.Font = new System.Drawing.Font("Mulish Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masalarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.masalarbtn.Location = new System.Drawing.Point(0, 406);
            this.masalarbtn.Name = "masalarbtn";
            this.masalarbtn.Size = new System.Drawing.Size(247, 56);
            this.masalarbtn.TabIndex = 6;
            this.masalarbtn.Text = "Masalar";
            this.masalarbtn.UseVisualStyleBackColor = true;
            this.masalarbtn.Click += new System.EventHandler(this.masalarbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 1);
            this.panel2.TabIndex = 3;
            // 
            // VerilerBtn
            // 
            this.VerilerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.VerilerBtn.FlatAppearance.BorderSize = 0;
            this.VerilerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerilerBtn.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VerilerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.VerilerBtn.Location = new System.Drawing.Point(0, 349);
            this.VerilerBtn.Name = "VerilerBtn";
            this.VerilerBtn.Size = new System.Drawing.Size(247, 56);
            this.VerilerBtn.TabIndex = 5;
            this.VerilerBtn.Text = "Veriler";
            this.VerilerBtn.UseVisualStyleBackColor = true;
            // 
            // PersonellerBtn
            // 
            this.PersonellerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonellerBtn.FlatAppearance.BorderSize = 0;
            this.PersonellerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonellerBtn.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonellerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.PersonellerBtn.Location = new System.Drawing.Point(0, 293);
            this.PersonellerBtn.Name = "PersonellerBtn";
            this.PersonellerBtn.Size = new System.Drawing.Size(247, 56);
            this.PersonellerBtn.TabIndex = 4;
            this.PersonellerBtn.Text = "Personeller";
            this.PersonellerBtn.UseVisualStyleBackColor = true;
            this.PersonellerBtn.Click += new System.EventHandler(this.PersonellerBtn_Click);
            // 
            // UrunlerBtn
            // 
            this.UrunlerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UrunlerBtn.FlatAppearance.BorderSize = 0;
            this.UrunlerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UrunlerBtn.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunlerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.UrunlerBtn.Location = new System.Drawing.Point(0, 237);
            this.UrunlerBtn.Name = "UrunlerBtn";
            this.UrunlerBtn.Size = new System.Drawing.Size(247, 56);
            this.UrunlerBtn.TabIndex = 3;
            this.UrunlerBtn.Text = "Urunler";
            this.UrunlerBtn.UseVisualStyleBackColor = true;
            this.UrunlerBtn.Click += new System.EventHandler(this.UrunlerBtn_Click);
            // 
            // SiparislerBtn
            // 
            this.SiparislerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SiparislerBtn.FlatAppearance.BorderSize = 0;
            this.SiparislerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SiparislerBtn.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SiparislerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.SiparislerBtn.Location = new System.Drawing.Point(0, 181);
            this.SiparislerBtn.Name = "SiparislerBtn";
            this.SiparislerBtn.Size = new System.Drawing.Size(247, 56);
            this.SiparislerBtn.TabIndex = 2;
            this.SiparislerBtn.Text = "Siparisler";
            this.SiparislerBtn.UseVisualStyleBackColor = true;
            this.SiparislerBtn.Click += new System.EventHandler(this.SiparislerBtn_Click);
            // 
            // GozAtBtn
            // 
            this.GozAtBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GozAtBtn.FlatAppearance.BorderSize = 0;
            this.GozAtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GozAtBtn.Font = new System.Drawing.Font("Mulish", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GozAtBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.GozAtBtn.Location = new System.Drawing.Point(0, 125);
            this.GozAtBtn.Name = "GozAtBtn";
            this.GozAtBtn.Size = new System.Drawing.Size(247, 56);
            this.GozAtBtn.TabIndex = 1;
            this.GozAtBtn.Text = "Göz At";
            this.GozAtBtn.UseVisualStyleBackColor = true;
            this.GozAtBtn.Click += new System.EventHandler(this.GozAtBtn_Click);
            // 
            // logopanel
            // 
            this.logopanel.Controls.Add(this.pictureBox2);
            this.logopanel.Controls.Add(this.panel1);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(247, 125);
            this.logopanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 125);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.backgroundPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dashboard_FormClosing);
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.backgroundPanel.ResumeLayout(false);
            this.leftsidepanel.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel leftsidepanel;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button GozAtBtn;
        private System.Windows.Forms.Button VerilerBtn;
        private System.Windows.Forms.Button PersonellerBtn;
        private System.Windows.Forms.Button UrunlerBtn;
        private System.Windows.Forms.Button SiparislerBtn;
        public System.Windows.Forms.Panel FormsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button masalarbtn;
        public System.Windows.Forms.Button siparisbtn;
    }
}

