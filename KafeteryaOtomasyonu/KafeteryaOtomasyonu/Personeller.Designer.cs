namespace KafeteryaOtomasyonu
{
    partial class Personeller
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.pIsmi = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pSoyismi = new System.Windows.Forms.Label();
            this.calismaSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Mulish", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TitleLabel.Location = new System.Drawing.Point(23, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(189, 44);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Personeller";
            // 
            // pIsmi
            // 
            this.pIsmi.AutoSize = true;
            this.pIsmi.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pIsmi.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pIsmi.Location = new System.Drawing.Point(88, 102);
            this.pIsmi.Name = "pIsmi";
            this.pIsmi.Size = new System.Drawing.Size(101, 20);
            this.pIsmi.TabIndex = 14;
            this.pIsmi.Text = "Personel Ismi";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1119, 631);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // pSoyismi
            // 
            this.pSoyismi.AutoSize = true;
            this.pSoyismi.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pSoyismi.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pSoyismi.Location = new System.Drawing.Point(333, 102);
            this.pSoyismi.Name = "pSoyismi";
            this.pSoyismi.Size = new System.Drawing.Size(57, 20);
            this.pSoyismi.TabIndex = 16;
            this.pSoyismi.Text = "Soyadi";
            // 
            // calismaSayisi
            // 
            this.calismaSayisi.AutoSize = true;
            this.calismaSayisi.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calismaSayisi.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.calismaSayisi.Location = new System.Drawing.Point(552, 102);
            this.calismaSayisi.Name = "calismaSayisi";
            this.calismaSayisi.Size = new System.Drawing.Size(95, 20);
            this.calismaSayisi.TabIndex = 17;
            this.calismaSayisi.Text = "Görev Sayisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(821, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Aktif";
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1119, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calismaSayisi);
            this.Controls.Add(this.pSoyismi);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pIsmi);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Mulish", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Personeller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label pIsmi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label pSoyismi;
        private System.Windows.Forms.Label calismaSayisi;
        private System.Windows.Forms.Label label1;
    }
}