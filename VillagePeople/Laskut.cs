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
    public partial class Laskut : Form
    {
        private DBConnect yhteys;
        private DataTable dtlaskut;
        private DataTable dtvaraukset;
        private DataTable valitturow;
        private int valittu;

        //Tällä saadaan muutettua ComboBoxin näkyvät arvot
        Dictionary<string, string> hakuKriteeri1 = new Dictionary<string, string>
        {   {"Mikä tahansa", "0"},
            {"ID", "l.lasku_id"},
            {"Asiakas", "l.nimi"},
            {"Osoite", "CONCAT(l.lahiosoite, ', ', l.postinro, ' ', l.postitoimipaikka)"}
        };

        //Tällä saadaan muutettua ComboBoxin näkyvät arvot
        Dictionary<string, string> hakuKriteeri2 = new Dictionary<string, string>
        {   {"Ei valintaa", "0"},
            {"Laskun pvm", "l.lasku_pvm"},
            {"Varaus pvm", "v.varattu_pvm"}
        };

        //Formin alustus
        public Laskut()
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
                dtlaskut = yhteys.HaeTiedot("SELECT l.lasku_id AS 'ID', l.lasku_pvm AS 'Laskun pvm', v.varattu_pvm AS 'Varaus pvm', l.nimi AS 'Nimi', " +
                    "CONCAT(l.lahiosoite, ', ', l.postinro, ' ', l.postitoimipaikka) AS 'Osoite', l.summa as 'Summa' FROM lasku l JOIN varaus v " +
                    "ON v.varaus_id = l.varaus_id ORDER BY l.lasku_id");

                dgLaskut.DataSource = null;
                dgLaskut.DataSource = dtlaskut;

                //Hakee tiedot ComboBoxiin
                dtvaraukset = yhteys.HaeTiedot("SELECT v.varaus_id, CONCAT('ID: ', v.varaus_id, ', ', a.etunimi, ' ', a.sukunimi, ', ', t.nimi) " +
                    "AS varaus FROM varaus v JOIN asiakas a ON v.asiakas_id = a.asiakas_id JOIN toimipiste t ON t.toimipiste_id = v.toimipiste_id ORDER BY v.varaus_id");
                dtvaraukset.Rows.InsertAt(dtvaraukset.NewRow(), 0);
                cbVaraus.DataSource = null;
                cbVaraus.DataSource = dtvaraukset;
                cbVaraus.DisplayMember = "varaus";
                cbVaraus.ValueMember = "varaus_id";

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

            //Kenttien tyhjäys
            txtNimi.Clear();
            txtLahiosoite.Clear();
            txtPostinro.Clear();
            txtPostitmp.Clear();
            txtHakusana.Clear();
        }

        //Lisää-tab
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            //Tarkistaa, että varaus on valittuna ja kentät ei tyhjät
            if (cbVaraus.FindStringExact(cbVaraus.Text) > -1 && !cbVaraus.Text.Equals("") && !string.IsNullOrEmpty(txtNimi.Text) &&
                !string.IsNullOrEmpty(txtLahiosoite.Text) && !string.IsNullOrEmpty(txtPostinro.Text) && !string.IsNullOrEmpty(txtPostitmp.Text))
            {
                try
                {
                    yhteys.Suorita("INSERT INTO lasku (varaus_id, lasku_pvm, nimi, lahiosoite, postitoimipaikka, postinro, summa, alv) VALUES ('" +
                        cbVaraus.SelectedValue + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + txtNimi.Text + "', '" + txtLahiosoite.Text + "', '" +
                        txtPostitmp.Text + "', '" + txtPostinro.Text + "', " +
                        "(SELECT IFNULL(SUM(hinta * lkm), 0) FROM varauksen_palvelut vp JOIN palvelu p ON vp.palvelu_id = p.palvelu_id WHERE vp.varaus_id='" + cbVaraus.SelectedValue + "'), '24')");

                    ReloadForm();
                    tcLaskut.SelectedIndex = 0; //Vaihtaa tabia

                    //Avaa Laskun sen luonnin jälkeen
                    LaskunTiedot frmLaskunTiedot = new LaskunTiedot((int)dgLaskut.Rows[dgLaskut.Rows.Count - 1].Cells[0].Value);
                    frmLaskunTiedot.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Varaus pitää olla valittuna ja kentät eivät voi olla tyhjät.");
            }
        }

        //Poista-napin toiminta
        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (dgLaskut.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Haluatko varmasti poistaa laskun järjestelmästä?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        valittu = (int)dgLaskut.Rows[dgLaskut.CurrentRow.Index].Cells[0].Value;
                        yhteys.Suorita("DELETE FROM lasku WHERE lasku_id='" + valittu + "'");

                        ReloadForm();
                        MessageBox.Show("Lasku poistettu");
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
                if (cbPvmKriteeri.SelectedValue.Equals("l.lasku_pvm") || cbPvmKriteeri.SelectedValue.Equals("v.varattu_pvm"))
                {
                    dtvaraukset = yhteys.HaeTiedot("SELECT l.lasku_id AS 'ID', l.lasku_pvm AS 'Laskun pvm', v.varattu_pvm AS 'Varaus pvm', l.nimi AS 'Nimi', " +
                    "CONCAT(l.lahiosoite, ', ', l.postinro, ' ', l.postitoimipaikka) AS 'Osoite', l.summa as 'Summa' FROM lasku l JOIN varaus v " +
                    "ON v.varaus_id = l.varaus_id WHERE " + cbPvmKriteeri.SelectedValue + " LIKE '%" + dateHaku.Value.ToString("yyyy-MM-dd") + "%'");

                    dgLaskut.DataSource = null;
                    dgLaskut.DataSource = dtvaraukset;
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

                if (cbPvmKriteeri.SelectedValue.Equals("l.lasku_pvm") || cbPvmKriteeri.SelectedValue.Equals("v.varattu_pvm"))
                {
                    pvmHakuStr = " AND " + cbPvmKriteeri.SelectedValue + " LIKE '%" + dateHaku.Value.ToString("yyyy-MM-dd") + "%'";
                }

                dtlaskut = yhteys.HaeTiedot("SELECT l.lasku_id AS 'ID', l.lasku_pvm AS 'Laskun pvm', v.varattu_pvm AS 'Varaus pvm', l.nimi AS 'Nimi', " +
                    "CONCAT(l.lahiosoite, ', ', l.postinro, ' ', l.postitoimipaikka) AS 'Osoite', l.summa as 'Summa' FROM lasku l JOIN varaus v " +
                    "ON v.varaus_id = l.varaus_id WHERE (l.lasku_id LIKE '%" + txtHakusana.Text + "%' OR l.nimi LIKE '%" + txtHakusana.Text + "%' OR " +
                    "l.lahiosoite LIKE '%" + txtHakusana.Text + "%' OR l.postitoimipaikka LIKE '%" + txtHakusana.Text + "%' OR l.postinro LIKE '%" +
                    txtHakusana.Text + "%')" + pvmHakuStr);

                dgLaskut.DataSource = null;
                dgLaskut.DataSource = dtlaskut;
            }
            //Kriteeri valittu = hakee valitusta kriteeristä hakusanalla
            else
            {
                string pvmHakuStr = "";

                if (cbPvmKriteeri.SelectedValue.Equals("l.lasku_pvm") || cbPvmKriteeri.SelectedValue.Equals("v.varattu_pvm"))
                {
                    pvmHakuStr = " AND " + cbPvmKriteeri.SelectedValue + " LIKE '%" + dateHaku.Value.ToString("yyyy-MM-dd") + "%'";
                }

                dtlaskut = yhteys.HaeTiedot("SELECT l.lasku_id AS 'ID', l.lasku_pvm AS 'Laskun pvm', v.varattu_pvm AS 'Varaus pvm', l.nimi AS 'Nimi', " +
                    "CONCAT(l.lahiosoite, ', ', l.postinro, ' ', l.postitoimipaikka) AS 'Osoite', l.summa as 'Summa' FROM lasku l JOIN varaus v " +
                    "ON v.varaus_id = l.varaus_id WHERE " + cbKriteeri.SelectedValue + " LIKE '%" + txtHakusana.Text + "%'" + pvmHakuStr);

                dgLaskut.DataSource = null;
                dgLaskut.DataSource = dtlaskut;
            }
        }

        //Tyhjentää kentät
        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        //Hakee tiedot valmiiksi tekstikenttiin, kun varaus valitaan
        private void cbVaraus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            valitturow = yhteys.HaeTiedot("SELECT * FROM asiakas WHERE asiakas_id = (SELECT asiakas_id FROM varaus WHERE varaus_id = '" + cbVaraus.SelectedValue + "')");

            if (valitturow.Rows.Count == 1)
            {
                txtNimi.Text = valitturow.Rows[0].ItemArray.GetValue(1).ToString() + " " + valitturow.Rows[0].ItemArray.GetValue(2).ToString();
                txtLahiosoite.Text = valitturow.Rows[0].ItemArray.GetValue(3).ToString();
                txtPostitmp.Text = valitturow.Rows[0].ItemArray.GetValue(4).ToString();
                txtPostinro.Text = valitturow.Rows[0].ItemArray.GetValue(5).ToString();
            }
            else
            {
                txtNimi.Text = "";
                txtLahiosoite.Text = "";
                txtPostitmp.Text = "";
                txtPostinro.Text = "";
            }
        }

        private void btnAvaa_Click(object sender, EventArgs e)
        {
            valittu = (int)dgLaskut.Rows[dgLaskut.CurrentRow.Index].Cells[0].Value;
            LaskunTiedot frmLaskunTiedot = new LaskunTiedot(valittu);
            frmLaskunTiedot.Show();
        }
    }
}
