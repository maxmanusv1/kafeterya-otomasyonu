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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            siparisDegerleri.siparisKodu = siparisKoduUret();
            firstPage.Visible = true;
            urunSepetiPanel.AutoScroll = false;
            urunSepetiPanel.HorizontalScroll.Maximum = 0;
            urunSepetiPanel.VerticalScroll.Visible = false;
            urunSepetiPanel.AutoScroll = true;
            Button[] buttons = { menulerbtn, sicakIceceklerBtn, sogukIceceklerBtn, tatlilarBtn,sebzelerBtn,kurupastalarBtn};
            FlowLayoutPanel[] panels = { menulerPanel, sicakIceceklerPanel, sogukIceceklerPanel, tatlilarPanel, sebzelerPanel,kurupastalarPanel };
            foreach (var item in panels)
            {
                item.Visible = false;
            }
            database database = new database();
            var list = new List<database.UrunDegeri>(); 
            for (int i = 0; i < buttons.Length; i++)
            {
                list = database.GetUruns(buttons[i].Text);
                for (int z = 0; z < list.Count; z++)
                {
                    UrunEkle urun = new UrunEkle();
                    urun.UrunIsmi.Text = list[z].UrunIsmi;
                    urun.urunKategori.Text = list[z].Kategori;
                    urun.urunFiyat.Text = list[z].Fiyat;
                    panels[i].Controls.Add(urun);
                }
                list.Clear();
                System.Threading.Thread.Sleep(25);
            }
           
        }
       
        public int siparisKoduUret()
        {
            Random random = new Random();
            int randomSayi = random.Next(000000, 999999);
            return randomSayi;
        }

        SiparisDegerleri siparisDegerleri = new SiparisDegerleri();
        List<Urunler> urunlerListesi = new List<Urunler>();
        public class SiparisDegerleri 
        {
            public string dateTime { get; set; }
            public string siparisDetay { get; set; }
            public int siparisUcret { get; set; }
            public string siparisPersoneli { get; set; }
            public string siparisMasa { get; set; }
            public int siparisKodu { get; set; }
        }
        public class Urunler : SiparisDegerleri{
            public int urunKodu { get; set; }
            public string urunIsmi { get; set; }
            public int urunAdet { get; set; }
            public int urunFiyat { get; set; }

        }

        private void UrunYukle(FlowLayoutPanel panel)
        {
            if (panel.Visible == true)
                panel.Visible = false;
            else
                panel.Visible = true;
        }

    

        private void menulerbtn_Click(object sender, EventArgs e)
        {
            UrunYukle(menulerPanel);
        }

        private void sicakIceceklerBtn_Click(object sender, EventArgs e)
        {
            UrunYukle(sicakIceceklerPanel);
        }

        private void sogukIceceklerBtn_Click(object sender, EventArgs e)
        {
            UrunYukle(sogukIceceklerPanel);
        }

        private void tatlilarBtn_Click(object sender, EventArgs e)
        {
            UrunYukle(tatlilarPanel);
        }

        private void sebzelerBtn_Click(object sender, EventArgs e)
        {
            UrunYukle(sebzelerPanel);
        }

        private void kurupastalarBtn_Click(object sender, EventArgs e)
        {
            UrunYukle(kurupastalarPanel);
        }

        private void secondPage_VisibleChanged(object sender, EventArgs e)
        {
            var list = new List<database.MasaVeri>();
            database database = new database();
            list = database.getMasalar();
            for (int i = 0; i < list.Count; i++)
            {
                Masa masa = new Masa();
                masa.tableLayoutPanel1.Click += TableLayoutPanel1_Click;
                masa.masaismiLabel.Text = list[i].MasaIsmi.ToString();
                masa.aciklamaLabel.Text = list[i].MasaAciklama.ToString();
                if (list[i].Durum.ToString() == "1")
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
                flowLayoutPanel2.Controls.Add(masa);
            }
           
        }

        private void TableLayoutPanel1_Click(object sender, EventArgs e)
        {
            TableLayoutPanel layoutPanel = sender as TableLayoutPanel;
            Control[] control = layoutPanel.Controls.Find("masaismiLabel",true);
            siparisDegerleri.siparisMasa = control[0].Text.ToString();
            secondPage.Visible = false;
            thirdpage.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            secondPage.Visible = false;
            firstPage.Visible = true;
        }

        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            if (urunSepetiPanel.Controls.Count != 0)
            {
                foreach (Control item in urunSepetiPanel.Controls)
                {
                    SepetUrun urun = item as SepetUrun;
                    urunlerListesi.Add(new Urunler { urunKodu = siparisDegerleri.siparisKodu, urunIsmi = urun.UrunIsmi.Text, urunFiyat = int.Parse(urun.ucret.Text), urunAdet = int.Parse(urun.adet.Text)});
                }
                siparisDegerleri.dateTime = DateTime.Now.ToString();
                siparisDegerleri.siparisUcret = int.Parse(totalUcret.Text);
                firstPage.Visible = false;
                secondPage.Visible = true;
            }
            else
                MessageBox.Show("Sepet boş olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void secondPage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void urunSepetiPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            thirdpage.Visible = false;
            secondPage.Visible = true;
        }
        private void thirdpage_VisibleChanged(object sender, EventArgs e)
        {
            List<database.Personel> personels;
            database database = new database();
            personels = database.GetPersonels();
            for (int i = 0; i < personels.Count; i++)
            {
                if (Convert.ToBoolean(personels[i].Aktif) == true)
                {
                    Personel personel = new Personel();
                    personel.Click += Personel_Click;
                    personel.PersonelIsmi.Text = personels[i].PersonelIsmi;
                    personel.soyadiLabel.Text = personels[i].Soyadi;
                    personel.calismaLabel.Text = personels[i].CalismaSayisi;
                    personel.panel1.Visible = false;
                    flowLayoutPanel3.Controls.Add(personel);
                }
            }
        }

        private void Personel_Click(object sender, EventArgs e)
        {
            Personel personel = sender as Personel;
            Control[] controls = personel.Controls.Find("PersonelIsmi",true);
            siparisDegerleri.siparisPersoneli = controls[0].Text;
            database database = new database();
            database.InsertSiparisDetayı(siparisDegerleri.dateTime,siparisDegerleri.siparisKodu,siparisDegerleri.siparisUcret,siparisDegerleri.siparisMasa,siparisDegerleri.siparisPersoneli,urunlerListesi);
            MessageBox.Show("Sipariş Oluşturuldu! ","", MessageBoxButtons.OK,MessageBoxIcon.Information);
            var frm = (dashboard)this.Owner;
            if (frm != null)
                frm.siparisbtn.PerformClick();

        }

        private void firstPage_VisibleChanged(object sender, EventArgs e)
        {
           
        }
    }
}
