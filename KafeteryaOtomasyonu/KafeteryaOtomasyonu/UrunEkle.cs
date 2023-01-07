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
    public partial class UrunEkle : UserControl
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > 1)
                textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void sepeteEkleBtn_Click(object sender, EventArgs e)
        {
            if (UrunIsmi.Text == "Mozaik Pasta")
            {
                if (Convert.ToInt32(textBox1.Text)==2)
                {
                    int ucret = (int.Parse(textBox1.Text) * int.Parse(urunFiyat.Text));
                    SepetUrun urun = new SepetUrun();
                    urun.UrunIsmi.Text = UrunIsmi.Text;
                    urun.adet.Text = textBox1.Text;
                    urun.ucret.Text = ucret.ToString();
                    var panel = this.Parent as Panel;
                    var form = panel.TopLevelControl as Form;
                    ((FlowLayoutPanel)form.Controls.Find("urunSepetiPanel", true)[0]).Controls.Add(urun);
                    int totalucret = Convert.ToInt32(((Label)form.Controls.Find("totalucret", true)[0]).Text);
                    ((Label)form.Controls.Find("totalucret", true)[0]).Text = (totalucret + ucret).ToString();
                }
            }
            else
            {
                int ucret = (int.Parse(textBox1.Text) * int.Parse(urunFiyat.Text));
                SepetUrun urun = new SepetUrun();
                urun.UrunIsmi.Text = UrunIsmi.Text;
                urun.adet.Text = textBox1.Text;
                urun.ucret.Text = ucret.ToString();
                var panel = this.Parent as Panel;
                var form = panel.TopLevelControl as Form;
                ((FlowLayoutPanel)form.Controls.Find("urunSepetiPanel", true)[0]).Controls.Add(urun);
                int totalucret = Convert.ToInt32(((Label)form.Controls.Find("totalucret", true)[0]).Text);
                ((Label)form.Controls.Find("totalucret", true)[0]).Text = (totalucret + ucret).ToString();
            }
           
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
