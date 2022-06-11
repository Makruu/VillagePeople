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
    public partial class Varaukset : Form
    {
        private DBConnect yhteys;
        private DataTable dtvaraukset;
        private DataTable dtasiakkaat;
        private DataTable dttoimipisteet;
        private string valittu;

        //Tällä saadaan muutettua ComboBoxin näkyvät arvot
        Dictionary<string, string> hakuKriteeri1 = new Dictionary<string, string>
        {   {"Mikä tahansa", "0"},
            {"ID", "varaus_id"},
            {"Asiakas", "asiakas_id"},
            {"Toimipiste", "toimipiste_id"}
        };

        //Tällä saadaan muutettua ComboBoxin näkyvät arvot
        Dictionary<string, string> hakuKriteeri2 = new Dictionary<string, string>
        {   {"Ei valintaa", "0"},
            {"Varaus pvm", "varattu_pvm"},
            {"Varaus alkaa", "varattu_alkupvm"},
            {"Varaus loppuu", "varattu_loppupvm"}
        };

        //Formin alustus
        public Varaukset()
        {
            InitializeComponent();
            yhteys = new DBConnect();
            ReloadForm();
        }

        /*Tämä funktio hakee tiedot kannasta ja aina kutsuttaessa uudestaan päivittää ne.
         Tyhjentää myös tekstikentät*/
        public void ReloadForm()
        {
            try
            {
                //Hakee kaikki tiedot tauluun
                dtvaraukset = yhteys.HaeTiedot("SELECT v.varaus_id AS 'ID', CONCAT(a.etunimi, ' ', a.sukunimi) AS 'Asiakas', t.nimi AS 'Toimipiste', " +
                    "v.varattu_pvm AS 'Varaus pvm', v.varattu_alkupvm AS 'Varaus alkaa', v.varattu_loppupvm AS 'Varaus loppuu' FROM varaus v JOIN toimipiste t " +
                    "ON v.toimipiste_id = t.toimipiste_id JOIN asiakas a ON v.asiakas_id = a.asiakas_id ORDER BY v.varaus_id");

                dgVaraukset.DataSource = null;
                dgVaraukset.DataSource = dtvaraukset;

                //Hakee tiedot asiakkaat ComboBoxiin
                dtasiakkaat = yhteys.HaeTiedot("SELECT asiakas_id, CONCAT(etunimi, ' ', sukunimi, ' (', lahiosoite, ', ', postinro, ' ', postitoimipaikka, ')') " +
                    "AS asiakas FROM asiakas ORDER BY etunimi");
                dtasiakkaat.Rows.InsertAt(dtasiakkaat.NewRow(), 0);
                cbAsiakas.DataSource = null;
                cbAsiakas.DataSource = dtasiakkaat;
                cbAsiakas.DisplayMember = "asiakas";
                cbAsiakas.ValueMember = "asiakas_id";

                //Hakee tiedot toimipisteet ComboBoxiin
                dttoimipisteet = yhteys.HaeTiedot("SELECT toimipiste_id, nimi FROM toimipiste ORDER BY nimi");
                dttoimipisteet.Rows.InsertAt(dttoimipisteet.NewRow(), 0);
                cbToimipiste.DataSource = null;
                cbToimipiste.DataSource = dttoimipisteet;
                cbToimipiste.DisplayMember = "nimi";
                cbToimipiste.ValueMember = "toimipiste_id";

                //ComboBoxin arvojen asettaminen
                cbKriteeri.DataSource = null;
                cbKriteeri.DataSource = new BindingSource(hakuKriteeri1, null);
                cbKriteeri.DisplayMember = "Key";
                cbKriteeri.ValueMember = "Value";

                //ComboBoxin arvojen asettaminen
                cbPvmKriteeri.DataSource = null;
                cbPvmKriteeri.DataSource = new BindingSource(hakuKriteeri2, null);
                cbPvmKriteeri.DisplayMember = "Key";
                cbPvmKriteeri.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tapahtui virhe");
            }

            dateVarattu.Value = DateTime.Now;
            dateVarattualk.Value = DateTime.Now;
            dateVarattulop.Value = DateTime.Now.AddDays(1);
            txtHakusana.Clear();
            dateHaku.Value = DateTime.Now;
        }

        //Lisää-tab
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            //Tarkistaa, että asiakas on valittuna ja varauksen päättyminen on aloituksen jälkeen
            if (cbAsiakas.FindStringExact(cbAsiakas.Text) > -1 && cbToimipiste.FindStringExact(cbToimipiste.Text) > -1 && !cbAsiakas.Text.Equals("") &&
                !cbToimipiste.Text.Equals("") && dateVarattulop.Value > dateVarattualk.Value)
            {
                try
                {
                    dateVarattu.Value = DateTime.Now;
                    yhteys.Suorita("INSERT INTO varaus (asiakas_id, toimipiste_id, varattu_pvm, varattu_alkupvm, varattu_loppupvm) VALUES ('" +
                        cbAsiakas.SelectedValue + "', '" + cbToimipiste.SelectedValue + "', '" + dateVarattu.Value.ToString("yyyy-MM-dd") + "', '" +
                        dateVarattualk.Value.ToString("yyyy-MM-dd") + "', '" + dateVarattulop.Value.ToString("yyyy-MM-dd") + "')");

                    ReloadForm();
                    tcVaraukset.SelectedIndex = 0; //Vaihtaa tabia

                    VarauksenMuokkaus frmVarauksenMuokkaus = new VarauksenMuokkaus((int)dgVaraukset.Rows[dgVaraukset.Rows.Count - 1].Cells[0].Value, (Varaukset)Form.ActiveForm);
                    frmVarauksenMuokkaus.Show();
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

        //Muokkaa-napin toiminta
        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            if (dgVaraukset.SelectedCells.Count > 0)
            {
                VarauksenMuokkaus frmVarauksenMuokkaus = new VarauksenMuokkaus((int)dgVaraukset.Rows[dgVaraukset.CurrentRow.Index].Cells[0].Value, (Varaukset)Form.ActiveForm);
                frmVarauksenMuokkaus.Show();
            }
            else
            {
                MessageBox.Show("Varausta ei ole valittu.");
            }
        }

        //Poista-napin toiminta
        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (dgVaraukset.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Haluatko varmasti poistaa varauksen järjestelmästä?" + Environment.NewLine + 
                    "HUOM! Tämä poistaa myös varauksen laskun!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        valittu = dgVaraukset.Rows[dgVaraukset.CurrentRow.Index].Cells[0].Value.ToString();
                        yhteys.Suorita("DELETE FROM varaus WHERE varaus_id='" + valittu + "'");

                        ReloadForm();
                        MessageBox.Show("Varaus poistettu");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Virhe");
                    }
                }
            }
            else
            {
                MessageBox.Show("Varausta ei ole valittu.");
            }
        }

        //Hae-napin toiminta
        private void btnHae_Click(object sender, EventArgs e)
        {
            //Hakusana tyhjä, haetaan pelkän päivämäärän mukaan
            if (string.IsNullOrEmpty(txtHakusana.Text))
            {
                if ((cbPvmKriteeri.SelectedValue.Equals("varattu_pvm") || cbPvmKriteeri.SelectedValue.Equals("varattu_alkupvm")
                    || cbPvmKriteeri.SelectedValue.Equals("varattu_loppupvm")))
                {
                    dtvaraukset = yhteys.HaeTiedot("SELECT v.varaus_id AS 'ID', CONCAT(a.etunimi, ' ', a.sukunimi) AS 'Asiakas', t.nimi AS 'Toimipiste', v.varattu_pvm " +
                    "AS 'Varaus pvm', v.varattu_alkupvm AS 'Varaus alkaa', v.varattu_loppupvm AS 'Varaus loppuu' FROM varaus v JOIN toimipiste t ON " +
                    "v.toimipiste_id = t.toimipiste_id JOIN asiakas a ON v.asiakas_id = a.asiakas_id WHERE v." + cbPvmKriteeri.SelectedValue + " LIKE '%" +
                    dateHaku.Value.ToString("yyyy-MM-dd") + "%'");

                    dgVaraukset.DataSource = null;
                    dgVaraukset.DataSource = dtvaraukset;
                }
                else
                {
                    MessageBox.Show("Valitse joku hakukriteeri");
                }
            }
            //Kriteeriä ei ole valittu = hakee kaikista kentistä hakusanalla
            else if (txtHakusana.Text.Length > 0 && cbKriteeri.SelectedValue.Equals("0"))
            {
                string pvmHakuStr = "";

                if (cbPvmKriteeri.SelectedValue.Equals("varattu_pvm") || cbPvmKriteeri.SelectedValue.Equals("varattu_alkupvm")
                    || cbPvmKriteeri.SelectedValue.Equals("varattu_loppupvm"))
                {
                    pvmHakuStr = " AND v." + cbPvmKriteeri.SelectedValue + " LIKE '%" + dateHaku.Value.ToString("yyyy-MM-dd") + "%'";
                }

                dtvaraukset = yhteys.HaeTiedot("SELECT v.varaus_id AS 'ID', CONCAT(a.etunimi, ' ', a.sukunimi) AS 'Asiakas', t.nimi AS 'Toimipiste', v.varattu_pvm " +
                    "AS 'Varaus pvm', v.varattu_alkupvm AS 'Varaus alkaa', v.varattu_loppupvm AS 'Varaus loppuu' FROM varaus v JOIN toimipiste t ON " +
                    "v.toimipiste_id = t.toimipiste_id JOIN asiakas a ON v.asiakas_id = a.asiakas_id WHERE (v.varaus_id LIKE '%" + txtHakusana.Text +
                    "%' OR CONCAT(a.etunimi, ' ', a.sukunimi) LIKE '%" + txtHakusana.Text + "%' OR t.nimi LIKE '%" + txtHakusana.Text + "%')" + pvmHakuStr);

                dgVaraukset.DataSource = null;
                dgVaraukset.DataSource = dtvaraukset;
            }
            //Kriteeri valittu = hakee valitusta kriteeristä hakusanalla
            else
            {
                string haunOsa = "v." + cbKriteeri.SelectedValue;
                string hakuStr = txtHakusana.Text;
                string pvmHakuStr = "";

                if (cbKriteeri.SelectedValue.Equals("asiakas_id"))
                {
                    haunOsa = "CONCAT(a.etunimi, ' ', a.sukunimi)";
                }
                else if (cbKriteeri.SelectedValue.Equals("toimipiste_id"))
                {
                    haunOsa = "t.nimi";
                }

                if (cbPvmKriteeri.SelectedValue.Equals("varattu_pvm") || cbPvmKriteeri.SelectedValue.Equals("varattu_alkupvm")
                    || cbPvmKriteeri.SelectedValue.Equals("varattu_loppupvm"))
                {
                    pvmHakuStr = " AND v." + cbPvmKriteeri.SelectedValue + " LIKE '%" + dateHaku.Value.ToString("yyyy-MM-dd") + "%'";
                }

                dtvaraukset = yhteys.HaeTiedot("SELECT v.varaus_id AS 'ID', CONCAT(a.etunimi, ' ', a.sukunimi) AS 'Asiakas', t.nimi AS 'Toimipiste', v.varattu_pvm " +
                    "AS 'Varaus pvm', v.varattu_alkupvm AS 'Varaus alkaa', v.varattu_loppupvm AS 'Varaus loppuu' FROM varaus v JOIN toimipiste t ON " +
                    "v.toimipiste_id = t.toimipiste_id JOIN asiakas a ON v.asiakas_id = a.asiakas_id WHERE " + haunOsa + " LIKE '%" + hakuStr + "%'" + pvmHakuStr);

                dgVaraukset.DataSource = null;
                dgVaraukset.DataSource = dtvaraukset;
            }
        }

        //Tyhjentää kentät
        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            ReloadForm();
            tcVaraukset.SelectedIndex = 0;
        }
    }
}
