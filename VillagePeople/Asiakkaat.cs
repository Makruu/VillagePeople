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
    public partial class Asiakkaat : Form
    {
        private DBConnect yhteys;
        private DataTable dtasiakkaat;
        private string valittu;
        private bool muokkaus = false;

        Dictionary<string, string> hakuKriteerit = new Dictionary<string, string>
        {   {"Ei kriteeriä", "0"},
            {"ID", "asiakas_id"},
            {"Etunimi", "etunimi"},
            {"Sukunimi", "sukunimi"},
            {"Lähiosoite", "lahiosoite"},
            {"Postitoimipaikka", "postitoimipaikka"},
            {"Postinumero", "postinro"},
            {"E-mail", "email"},
            {"Puhelinnumero", "puhelinnro"}
        };


        private void BtnPoista_Click(object sender, EventArgs e)
        {
            if (dgAsiakkaat.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Haluatko varmasti poistaa asiakkaan järjestelmästä?" + Environment.NewLine + 
                    "HUOM! Tämä poistaa myös kaikki asiakkaan varaukset sekä laskut!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        valittu = dgAsiakkaat.Rows[dgAsiakkaat.CurrentRow.Index].Cells[0].Value.ToString();
                        yhteys.Suorita("DELETE FROM asiakas WHERE asiakas_id='" + valittu + "'");

                        ReloadForm();
                        MessageBox.Show("asiakas poistettu");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Virhe");
                    }
                }
            }
            else
            {
                MessageBox.Show("Asiakasta ei ole valittu.");
            }
        }

        private void BtnMuokkaa_Click(object sender, EventArgs e)
        {
            if (dgAsiakkaat.SelectedCells.Count > 0)
            {
                try
                {
                    muokkaus = true;
                    valittu = dgAsiakkaat.Rows[dgAsiakkaat.CurrentRow.Index].Cells[0].Value.ToString();

                    DataRow drvalinta = yhteys.HaeTiedot("SELECT * FROM asiakas WHERE asiakas_id='" + valittu + "'").Rows[0];

                    txtEtunimi.Text = drvalinta.ItemArray.GetValue(1).ToString();
                    txtSukunimi.Text = drvalinta.ItemArray.GetValue(2).ToString();
                    txtLahiosoite.Text = drvalinta.ItemArray.GetValue(3).ToString();
                    txtPostitoimipaikka.Text = drvalinta.ItemArray.GetValue(4).ToString();
                    txtPostinro.Text = drvalinta.ItemArray.GetValue(5).ToString();
                    txtEmail.Text = drvalinta.ItemArray.GetValue(6).ToString();
                    txtPuhelinnro.Text = drvalinta.ItemArray.GetValue(7).ToString();

                    tcAsiakkaat.SelectedIndex = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Virhe");
                }
            }
            else
            {
                MessageBox.Show("Asiakasta ei ole valittu.");
            }
        }

        private void BtnPeruuta_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        public Asiakkaat()
        {
            InitializeComponent();
            yhteys = new DBConnect();
            ReloadForm();
        }

        private void ReloadForm()
        {
            try
            {
                dtasiakkaat = yhteys.HaeTiedot("SELECT asiakas_id AS 'ID', etunimi AS 'Etunimi', sukunimi AS 'Sukunimi', lahiosoite AS 'Lahiosoite', " +
                    "postitoimipaikka AS 'Postitoimipaikka', postinro AS 'Postinumero', email AS 'E-mail', puhelinnro AS 'Puh. nro' FROM asiakas ORDER BY asiakas_id");

                dgAsiakkaat.DataSource = null;
                dgAsiakkaat.DataSource = dtasiakkaat;

                cbKriteeri.DataSource = null;
                cbKriteeri.DataSource = new BindingSource(hakuKriteerit, null);
                cbKriteeri.DisplayMember = "Key";
                cbKriteeri.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tapahtui virhe");
            }

            muokkaus = false;
            txtEtunimi.Clear();
            txtSukunimi.Clear();
            txtLahiosoite.Clear();
            txtPostitoimipaikka.Clear();
            txtPostinro.Clear();
            txtEmail.Clear();
            txtPuhelinnro.Clear();
            txtHakusana.Clear();
            cbKriteeri.SelectedIndex = 0;
        }
        private void BtnTallenna_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEtunimi.Text) || string.IsNullOrEmpty(txtSukunimi.Text) || string.IsNullOrEmpty(txtLahiosoite.Text) || string.IsNullOrEmpty(txtPostitoimipaikka.Text) ||
                string.IsNullOrEmpty(txtPostinro.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPuhelinnro.Text))
            {
                MessageBox.Show("Kentät eivät voi olla tyhjiä");
            }
            else
            {
                try
                {                
                    if (muokkaus == false)
                    {
                        yhteys.Suorita("INSERT INTO asiakas (etunimi, sukunimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) VALUES ('" +
                            txtEtunimi.Text + "', '" + txtSukunimi.Text + "', '" + txtLahiosoite.Text + "', '" + txtPostitoimipaikka.Text + "', '" +
                            txtPostinro.Text + "', '" + txtEmail.Text + "', '" + txtPuhelinnro.Text + "')");
                    }
                    else
                    {
                        yhteys.Suorita("UPDATE asiakas SET etunimi='" + txtEtunimi.Text + "', sukunimi='" + txtSukunimi.Text + "', lahiosoite='" + txtLahiosoite.Text + "', postitoimipaikka='" +
                            txtPostitoimipaikka.Text + "', postinro='" + txtPostinro.Text + "', email='" + txtEmail.Text + "', puhelinnro='" + txtPuhelinnro.Text +
                            "' WHERE asiakas_id=" + valittu + ";");
                    }
                    ReloadForm();
                    tcAsiakkaat.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnHae_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHakusana.Text))
            {
                MessageBox.Show("Kirjoita hakusana");
            }
            else if (txtHakusana.Text.Length > 0 && cbKriteeri.SelectedValue.Equals("0"))
            {
                dtasiakkaat = yhteys.HaeTiedot("SELECT asiakas_id AS 'ID', etunimi AS 'Etunimi', sukunimi AS 'Sukunimi', lahiosoite AS 'Lahiosoite', " +
                    "postitoimipaikka AS 'Postitoimipaikka', postinro AS 'Postinumero', email AS 'E-mail', puhelinnro AS 'Puh. nro' FROM asiakas WHERE " +
                    "etunimi LIKE '%" + txtHakusana.Text + "%' OR sukunimi LIKE '%" + txtHakusana.Text + "%' OR lahiosoite LIKE '%" + txtHakusana.Text + "%' OR postitoimipaikka LIKE '%" + txtHakusana.Text + "%'" +
                    " OR postinro LIKE '%" + txtHakusana.Text + "%' OR email LIKE '%" + txtHakusana.Text + "%' OR puhelinnro LIKE '%" + txtHakusana.Text + "%';");
                dgAsiakkaat.DataSource = null;
                dgAsiakkaat.DataSource = dtasiakkaat;
            }
            else if (txtHakusana.Text.Length > 0)
            {
                dtasiakkaat = yhteys.HaeTiedot("SELECT asiakas_id AS 'ID', etunimi AS 'Etunimi', sukunimi AS 'Sukunimi', lahiosoite AS 'Lahiosoite', " +
                    "postitoimipaikka AS 'Postitoimipaikka', postinro AS 'Postinumero', email AS 'E-mail', puhelinnro AS 'Puh. nro' FROM asiakas WHERE " +
                    cbKriteeri.SelectedValue + " LIKE '%" + txtHakusana.Text + "%';");
                dgAsiakkaat.DataSource = null;
                dgAsiakkaat.DataSource = dtasiakkaat;
            }
        }

        private void BtnPalauta_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }
    }
}
