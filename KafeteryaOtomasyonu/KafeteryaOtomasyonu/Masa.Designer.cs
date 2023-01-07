namespace KafeteryaOtomasyonu
{
    partial class Masa
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
            this.masaismiLabel = new System.Windows.Forms.Label();
            this.aciklamaLabel = new System.Windows.Forms.Label();
            this.durumLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masaismiLabel
            // 
            this.masaismiLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.masaismiLabel.AutoSize = true;
            this.masaismiLabel.Font = new System.Drawing.Font("Mulish", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masaismiLabel.Location = new System.Drawing.Point(81, 0);
            this.masaismiLabel.Name = "masaismiLabel";
            this.masaismiLabel.Size = new System.Drawing.Size(99, 33);
            this.masaismiLabel.TabIndex = 0;
            this.masaismiLabel.Text = "Masa 1";
            // 
            // aciklamaLabel
            // 
            this.aciklamaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aciklamaLabel.AutoSize = true;
            this.aciklamaLabel.Font = new System.Drawing.Font("Mulish", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aciklamaLabel.Location = new System.Drawing.Point(112, 45);
            this.aciklamaLabel.Name = "aciklamaLabel";
            this.aciklamaLabel.Size = new System.Drawing.Size(38, 15);
            this.aciklamaLabel.TabIndex = 1;
            this.aciklamaLabel.Text = "Kat 2 ";
            // 
            // durumLabel
            // 
            this.durumLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.durumLabel.AutoSize = true;
            this.durumLabel.Font = new System.Drawing.Font("Mulish", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumLabel.ForeColor = System.Drawing.Color.Black;
            this.durumLabel.Location = new System.Drawing.Point(109, 120);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(44, 20);
            this.durumLabel.TabIndex = 2;
            this.durumLabel.Text = "Aktif";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Location = new System.Drawing.Point(109, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 12);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.durumLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.masaismiLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.aciklamaLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 152);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.DoubleClick += new System.EventHandler(this.tableLayoutPanel1_DoubleClick);
            // 
            // Masa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Mulish", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Masa";
            this.Size = new System.Drawing.Size(260, 150);
            this.Load += new System.EventHandler(this.Masa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label masaismiLabel;
        public System.Windows.Forms.Label aciklamaLabel;
        public System.Windows.Forms.Label durumLabel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
