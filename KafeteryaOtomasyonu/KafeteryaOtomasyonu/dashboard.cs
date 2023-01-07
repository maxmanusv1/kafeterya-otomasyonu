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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            GozAtBtn.PerformClick();
        
        }
        Color buttonBackColors = Color.FromArgb(54, 55, 64);
        Color buttonOnClickedBackColor = Color.FromArgb(76, 79, 91);
        Color buttonForeColors = Color.FromArgb(164,166,179);
        Color buttonOnClickedForeColor = Color.FromArgb(201, 206, 232);
        private void RefreshButtons(Button NewButton)
        {
            Button[] buttons = { GozAtBtn, SiparislerBtn,UrunlerBtn,PersonellerBtn,VerilerBtn,masalarbtn,siparisbtn };
            foreach (var item in buttons)
            {
                item.BackColor = buttonBackColors;
                item.ForeColor = buttonForeColors;
                if (item.Name == NewButton.Name)
                {
                    item.BackColor = buttonOnClickedBackColor;
                    item.ForeColor = buttonOnClickedForeColor;
                }
            }
            FormsPanel.Controls.Clear();
        }
        public void siparisbtnBas()
        {
            SiparislerBtn.PerformClick();
        }

        private void GozAtBtn_Click(object sender, EventArgs e)
        {
            RefreshButtons(GozAtBtn);
            StartScreen startScreen = new StartScreen();
            startScreen.TopLevel = false;
            startScreen.AutoScroll = true;
            FormsPanel.Controls.Add(startScreen);
            startScreen.Show();
        }

        private void SiparislerBtn_Click(object sender, EventArgs e)
        {
            RefreshButtons(SiparislerBtn);
            Siparisler siparisler1 = new Siparisler();
            siparisler1.TopLevel = false;
            siparisler1.AutoScroll = true;
            this.FormsPanel.Controls.Add(siparisler1);
            siparisler1.Show();
        }

        private void UrunlerBtn_Click(object sender, EventArgs e)
        {
            RefreshButtons(UrunlerBtn);
            Urunler urunler = new Urunler();
            urunler.TopLevel = false;
            urunler.AutoScroll = false;
            FormsPanel.Controls.Add(urunler);
            urunler.Show();
        }

        private void PersonellerBtn_Click(object sender, EventArgs e)
        {
            RefreshButtons(PersonellerBtn);
            Personeller personeller = new Personeller();
            personeller.TopLevel = false;
            personeller.AutoScroll = false;
            FormsPanel.Controls.Add(personeller);
            personeller.Show();
        }

        private void masalarbtn_Click(object sender, EventArgs e)
        {
            RefreshButtons(masalarbtn);
            Masalar masalar = new Masalar();
            masalar.TopLevel = false;
            masalar.AutoScroll = false;
            FormsPanel.Controls.Add(masalar);
            masalar.Show();
        }

        private void siparisbtn_Click(object sender, EventArgs e)
        {
            RefreshButtons(siparisbtn);
            SiparisOlustur olustur = new SiparisOlustur();
            olustur.TopLevel = false;
            olustur.AutoScroll = false;
            FormsPanel.Controls.Add(olustur);
            olustur.Show();
        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
