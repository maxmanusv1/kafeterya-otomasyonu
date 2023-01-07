using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeteryaOtomasyonu
{
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }

        private void Masalar_Load(object sender, EventArgs e)
        {
            var list = new List<database.MasaVeri>();
            database database = new database();
            list = database.getMasalar();
            for (int i = 0; i < list.Count; i++)
            {
                Masa masa = new Masa();
                masa.masaismiLabel.Text = list[i].MasaIsmi.ToString();
                masa.aciklamaLabel.Text = list[i].MasaAciklama.ToString();
                if (list[i].Durum.ToString()=="1")
                {
                    masa.durumLabel.Text = "Hazir";
                    masa.panel1.BackColor = Color.Green;
                }
                else if (list[i].Durum.ToString() == "2")
                {
                    masa.durumLabel.Text = "Kullanımda";
                    masa.panel1.BackColor = Color.Red;
                }
                else
                {
                    masa.durumLabel.Text = "Rezerve";
                    masa.panel1.BackColor = Color.Orange;
                }
                flowLayoutPanel1.Controls.Add(masa);
            }
        }
    }
}
