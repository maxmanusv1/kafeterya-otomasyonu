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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            List<database.Personel> personels;
            database database = new database();
            personels = database.GetPersonels();
            for (int i = 0; i < personels.Count; i++)
            {
                Personel personel = new Personel();
                personel.PersonelIsmi.Text = personels[i].PersonelIsmi;
                personel.soyadiLabel.Text = personels[i].Soyadi;
                personel.calismaLabel.Text = personels[i].CalismaSayisi;
                personel.panel1.BackColor =  Convert.ToBoolean(personels[i].Aktif) == true ? personel.panel1.BackColor = Color.Green : personel.panel1.BackColor = Color.Red;
                flowLayoutPanel1.Controls.Add(personel);
            }
        }
    }
}
