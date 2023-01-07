using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeteryaOtomasyonu
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            var list = new List<database.SiparisDetayi>();
            database database = new database();
            list = database.siparisler();
            for (int i = 0; i < list.Count; i++)
            {
                SiparislerUserControl siparisler = new SiparislerUserControl();
                siparisler.MasaLabel.Text = list[i].siparisMasa;
                siparisler.PersonelLabel.Text = list[i].siparisPersoneli;
                siparisler.TarihLabel.Text = list[i].siparisZamani;
                flowLayoutPanel1.Controls.Add(siparisler);
            }
        }
    }
}
