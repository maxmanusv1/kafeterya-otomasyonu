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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }
        Color maviRenk = Color.FromArgb(55,81,255);
        Color acikMavi = Color.FromArgb(159,162,180);


        private void GunlukSiparisPanel_MouseEnter(object sender, EventArgs e)
        {
            gunluksiparisLabel.ForeColor = maviRenk;
            gunlukadetLabel.ForeColor = maviRenk;
        }

        private void GunlukSiparisPanel_MouseLeave(object sender, EventArgs e)
        {
            gunluksiparisLabel.ForeColor = acikMavi;
            gunlukadetLabel.ForeColor = Color.Black;
        }

        private void aktifsiparislerPanel_MouseEnter(object sender, EventArgs e)
        {
            aktifsiparislerLabel.ForeColor = maviRenk;
            aktifsiparislersayiLabel.ForeColor = maviRenk;
        }

        private void aktifsiparislerPanel_MouseLeave(object sender, EventArgs e)
        {
            aktifsiparislerLabel.ForeColor = acikMavi;
            aktifsiparislersayiLabel.ForeColor = Color.Black;
        }

        private void gerceklesmisPanel_MouseEnter(object sender, EventArgs e)
        {
            gerceklesmissiparislerLabel.ForeColor = maviRenk;
            gerceklesmissayiLabel.ForeColor = maviRenk;
        }

        private void gerceklesmisPanel_MouseLeave(object sender, EventArgs e)
        {
            gerceklesmissiparislerLabel.ForeColor = acikMavi;
            gerceklesmissayiLabel.ForeColor = Color.Black;
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
