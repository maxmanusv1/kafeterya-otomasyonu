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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
        }
        public void LoadPage(string kategori)
        {
            FirstPage.Visible = false;
            SecondPage.Visible = true;
            kategoriIsmi.Text = kategori;
            database database = new database();
            var list = new List<database.UrunDegeri>() ;
                list = database.GetUruns(kategori);
            kategoriMenuListele.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                UrunListele listele = new UrunListele();
                listele.UrunIsmi.Text = list[i].UrunIsmi;
                listele.Kategori.Text = list[i].Kategori;
                listele.Adet.Text = String.IsNullOrEmpty(list[i].Adet) ? "X" : list[i].Adet;
                listele.Fiyat.Text = list[i].Fiyat;
                listele.SatilanAdet.Text = list[i].SatilanAdet;
                kategoriMenuListele.Controls.Add(listele);
            }
        }


        private void menulerPbox_Click(object sender, EventArgs e)
        {
            LoadPage("Menuler");
        }

        private void SecondPage_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void SicakIcecekler_Click(object sender, EventArgs e)
        {
            LoadPage("Sıcak Icecekler");
        }

        private void sogukIcecekler_Click(object sender, EventArgs e)
        {
            LoadPage("Soguk Icecekler");
        }

        private void tatlilar_Click(object sender, EventArgs e)
        {
            LoadPage("Tatlılar");
        }

        private void sebzeler_Click(object sender, EventArgs e)
        {
            LoadPage("Sebzeler");
        }

        private void kuruPastalar_Click(object sender, EventArgs e)
        {
            LoadPage("Kuru Pastalar");
        }
        private void FirstPage_Click(object sender, EventArgs e)
        {
           
        }

        private void SecondPage_Click(object sender, EventArgs e)
        {
           

        }

        private void label12_Click(object sender, EventArgs e)
        {
            FirstPage.Visible = true;
            SecondPage.Visible = false;
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            label12.ForeColor = Color.FromArgb(13,23,92);
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.FromArgb(55, 81, 255);
        }

    }
}
