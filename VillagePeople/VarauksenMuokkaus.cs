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
    public partial class VarauksenMuokkaus : Form
    {
        private DBConnect yhteys;
        private DataTable dtpalvelut;
        private DataTable dtasiakkaat;
        private DataTable dttoimipisteet;
        private DataTable dtvalitutpalvelut;
        private DataRow varausrow;
        private int varausid;
        private Varaukset frmVaraukset;

        public VarauksenMuokkaus(int varaus, Varaukset varaukset)
        {
            varausid = varaus;
            frmVaraukset = varaukset;
            InitializeComponent();
            yhteys = new DBConnect();
            LataaForm();
            ReloadForm();
        }

        private void LataaForm()
        {
            try
            {
                dtasiakkaat = yhteys.HaeTiedot("SELECT asiakas_id, CONCAT(etunimi, ' ', sukunimi) AS nimi FROM asiakas");
                //ComboBoxin arvojen asettaminen
                cbAsiakas.DataSource = null;
                cbAsiakas.DataSource = dtasiakkaat;
                cbAsiakas.DisplayMember = "nimi";
                cbAsiakas.ValueMember = "asiakas_id";

                dttoimipisteet = yhteys.HaeTiedot("SELECT toimipiste_id, nimi FROM toimipiste");
                //ComboBoxin arvojen asettaminen
                cbToimipiste.DataSource = null;
                cbToimipiste.DataSource = dttoimipisteet;
                cbToimipiste.DisplayMember = "nimi";
                cbToimipiste.ValueMember = "toimipiste_id";

                DataRow drvalinta = yhteys.HaeTiedot("SELECT * FROM varaus WHERE varaus_id='" + varausid + "'").Rows[0];
                varausrow = drvalinta;

                cbAsiakas.SelectedValue = drvalinta.ItemArray.GetValue(1);
                cbToimipiste.SelectedValue = drvalinta.ItemArray.GetValue(2);
                dateVarattu.Value = DateTime.Parse(drvalinta.ItemArray.GetValue(3).ToString());
                dateVarattualk.Value = DateTime.Parse(drvalinta.ItemArray.GetValue(4).ToString());
                dateVarattulop.Value = DateTime.Parse(drvalinta.ItemArray.GetValue(5).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tapahtui virhe");
            }
        }

        private void ReloadForm()
        {
            try
            {
                //Hakee valitut palvelut etusivulle
                dtvalitutpalvelut = yhteys.HaeTiedot("SELECT p.palvelu_id AS 'ID', p.nimi AS 'Nimi', p.kuvaus AS 'Kuvaus', p.hinta AS 'Hinta/pv' FROM " +
                    "varauksen_palvelut vp JOIN palvelu p ON vp.palvelu_id = p.palvelu_id WHERE vp.varaus_id = '" + varausid + "'");
                dgValitutPalvelut.DataSource = null;
                dgValitutPalvelut.DataSource = dtvalitutpalvelut;
                //dgValitutPalvelut.Columns[0].Width = 10;

                //Palveluiden haku datagridiin
                dtpalvelut = yhteys.HaeTiedot("SELECT p.palvelu_id AS 'ID', p.nimi AS 'Nimi', p.kuvaus AS 'Kuvaus', p.hinta AS 'Hinta/pv'" +
                    ", p.alv AS 'Alv %' FROM palvelu p JOIN toimipiste t ON p.toimipiste_id = t.toimipiste_id WHERE p.toimipiste_id = " +
                    "(SELECT toimipiste_id FROM varaus WHERE varaus_id ='" + varausid + "') AND p.palvelu_id NOT IN " +
                    "(SELECT palvelu_id FROM varauksen_palvelut WHERE varaus_id ='" + varausid + "') ORDER BY p.palvelu_id");
                dgVarauksenPalvelut.DataSource = null;
                dgVarauksenPalvelut.DataSource = dtpalvelut;

                dgVarauksenPalvelut.Columns[1].ReadOnly = true;
                dgVarauksenPalvelut.Columns[2].ReadOnly = true;
                dgVarauksenPalvelut.Columns[3].ReadOnly = true;
                dgVarauksenPalvelut.Columns[4].ReadOnly = true;
                dgVarauksenPalvelut.Columns[5].ReadOnly = true;

                tcVaraukset.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tapahtui virhe");
            }
        }

        //Lisää valitut palvelut varaukselle
        private void btnLisaaPalvelut_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dr in dgVarauksenPalvelut.Rows)
                {
                    if (Convert.ToBoolean(Convert.ToBoolean(dr.Cells[0].Value)) == true)
                    {
                        yhteys.Suorita("INSERT INTO varauksen_palvelut (varaus_id, palvelu_id, lkm) VALUES ('" + varausid + "', '" +
                            dr.Cells[1].Value.ToString() + "', '" + (DateTime.Parse(varausrow.ItemArray.GetValue(5).ToString()) -
                            DateTime.Parse(varausrow.ItemArray.GetValue(4).ToString())).TotalDays + "')");
                    }
                }

                ReloadForm();
                tcVaraukset.SelectedIndex = 0;
                MessageBox.Show("Palvelut lisätty");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tapahtui virhe");
            }
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //Tarkistaa, että asiakas on valittuna ja varauksen päättyminen on aloituksen jälkeen
            if (cbAsiakas.FindStringExact(cbAsiakas.Text) > -1 && cbToimipiste.FindStringExact(cbToimipiste.Text) > -1 && !cbAsiakas.Text.Equals("") &&
                !cbToimipiste.Text.Equals("") && dateVarattulop.Value > dateVarattualk.Value)
            {
                try
                {
                    yhteys.Suorita("UPDATE varaus SET asiakas_id='" + cbAsiakas.SelectedValue + "', toimipiste_id='" + cbToimipiste.SelectedValue +
                        "', varattu_alkupvm='" + dateVarattualk.Value.ToString("yyyy-MM-dd") + "', varattu_loppupvm='" +
                        dateVarattulop.Value.ToString("yyyy-MM-dd") + "' WHERE varaus_id='" + varausid + "'");

                    yhteys.Suorita("UPDATE varauksen_palvelut SET lkm='" + (dateVarattulop.Value - dateVarattualk.Value).TotalDays + "' WHERE varaus_id='" + varausid + "'");

                    ReloadForm();
                    frmVaraukset.ReloadForm();
                    MessageBox.Show("Tiedot tallennettu");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Asiakas ja toimipiste pitää olla valittuna, ja varaus ei voi päättyä ennen sen alkua.");
            }
        }

        //Sulkee ikkunan
        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Vaihtaa välilehteä palvelut-tabille
        private void btnPalvelut_Click(object sender, EventArgs e)
        {
            ReloadForm();
            tcVaraukset.SelectedIndex = 1;
        }

        //Palaa etusivulle
        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            ReloadForm();
            tcVaraukset.SelectedIndex = 0;
        }

        //Poistaa valitun palvelun
        private void btnPoista_Click(object sender, EventArgs e)
        {
            try
            {
                yhteys.Suorita("DELETE FROM varauksen_palvelut WHERE varaus_id='" + varausid + "' AND palvelu_id='" +
                    dgValitutPalvelut.Rows[dgValitutPalvelut.CurrentRow.Index].Cells[0].Value + "'");

                ReloadForm();
                tcVaraukset.SelectedIndex = 0;
                MessageBox.Show("Valittu palvelu poistettu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tapahtui virhe");
            }
        }
    }
}
