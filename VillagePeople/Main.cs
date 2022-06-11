using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillagePeople
{
    public partial class Main : Form
    {
        //Alustus
        public Main()
        {
            InitializeComponent();
        }

        //Avaa Varaukset-ikkunan
        private void btnVaraukset_Click(object sender, EventArgs e)
        {
            Varaukset frmVaraukset = new Varaukset();
            frmVaraukset.Show();
        }

        //Avaa Laskut-ikkunan
        private void btnLaskut_Click(object sender, EventArgs e)
        {
            Laskut frmLaskut = new Laskut();
            frmLaskut.Show();
        }

        //Avaa Raportit-ikkunan
        private void btnRaportit_Click(object sender, EventArgs e)
        {
            Raportit frmRaportit = new Raportit();
            frmRaportit.Show();
        }

        //Avaa Asiakkaat-ikkunan
        private void btnAsiakkaat_Click(object sender, EventArgs e)
        {
            Asiakkaat frmAsiakkaat = new Asiakkaat();
            frmAsiakkaat.Show();
        }

        //Avaa Palvelut-ikkunan
        private void btnPalvelut_Click(object sender, EventArgs e)
        {
            Palvelut frmPalvelut = new Palvelut();
            frmPalvelut.Show();
        }

        //Avaa Toimipisteet-ikkunan
        private void btnToimipisteet_Click(object sender, EventArgs e)
        {
            Toimipisteet frmToimipisteet = new Toimipisteet();
            frmToimipisteet.Show();
        }
    }
}
