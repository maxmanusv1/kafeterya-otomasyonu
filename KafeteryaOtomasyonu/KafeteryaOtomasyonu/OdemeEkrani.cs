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
    public partial class OdemeEkrani : Form
    {
        public OdemeEkrani()
        {
            InitializeComponent();
        }
        public string masaIsmi;
      
        private void OdemeEkrani_Load(object sender, EventArgs e)
        {
            database db = new database();
            var list1 = new List<database.OdemeMasa>();
            list1 = db.siparisMasaDetay(masaIsmi);
            var list2 = new List<database.OdemeUrun>();
            list2 = db.siparisUrunleri(list1[0].SiparisID);
            masaismiLabel.Text = masaIsmi;
            for (int i = 0; i < list2.Count; i++)
            {
                SepetUrun urun = new SepetUrun();
                urun.button1.Visible = false;
                urun.UrunIsmi.Text = list2[i].UrunName;
                urun.adet.Text = list2[i].UrunAdet;
                urun.ucret.Text = list2[i].UrunFiyat;
                flowLayoutPanel1.Controls.Add(urun);
            }
            label1.Text = list1[0].SiparisUcret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database db = new database();
            var list1 = new List<database.OdemeMasa>();
            list1 = db.siparisMasaDetay(masaIsmi);
            database database = new database();
            database.SatisiBitir(list1[0].SiparisID, masaIsmi, list1[0].SiparisUcret);
            this.Close();
        }
    }
}
