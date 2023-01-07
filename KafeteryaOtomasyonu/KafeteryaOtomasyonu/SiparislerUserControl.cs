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
    public partial class SiparislerUserControl : UserControl
    {
        public SiparislerUserControl()
        {
            InitializeComponent();
        }
        public class Materials
        {
            public string MasaIsmi { get; set; }
            public string PersonelIsmi { get; set; }
            public DateTime Tarih { get; set; }
        }

        private void SiparislerUI_Load(object sender, EventArgs e)
        {

        }
    }
}
