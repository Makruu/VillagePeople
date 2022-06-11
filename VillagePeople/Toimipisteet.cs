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
    public partial class Toimipisteet : Form
    {
        private DBConnect yhteys;
        private DataTable dttoimipisteet;
        private string valittu;
        private bool muokkaus = false;

        //Tällä saadaan muutettua ComboBoxin näkyvät arvot
        Dictionary<string, string> hakuKriteerit = new Dictionary<string, string>
        {   {"Ei kriteeriä", "0"},
            {"ID", "toimipiste_id"},
            {"Nimi", "nimi"},
            {"Lähiosoite", "lahiosoite"},
            {"Postitoimipaikka", "postitoimipaikka"},
            {"Postinumero", "postinro"},
            {"E-mail", "email"},
            {"Puhelinnumero", "puhelinnro"}
        };

        public Toimipisteet()
        {
            InitializeComponent();
            yhteys = new DBConnect();
            ReloadForm();
        }

        /*Tämä funktio hakee tiedot kannasta ja aina kutsuttaessa uudestaan päivittää ne.
         Tyhjentää myös tekstikentät*/
        private void ReloadForm()
        {
            try
            {
                dttoimipisteet = yhteys.HaeTiedot("SELECT toimipiste_id AS 'ID', nimi AS 'Nimi', lahiosoite AS 'Lahiosoite', " +
                    "postitoimipaikka AS 'Postitoimipaikka', postinro AS 'Postinumero', email AS 'E-mail', puhelinnro AS 'Puh. nro' FROM toimipiste ORDER BY toimipiste_id");

                dgToimipisteet.DataSource = null;
                dgToimipisteet.DataSource = dttoimipisteet;

                //ComboBoxin arvojen asettaminen
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
            txtNimi.Clear();
            txtLahiosoite.Clear();
            txtPostitoimipaikka.Clear();
            txtPostinro.Clear();
            txtEmail.Clear();
            txtPuhnro.Clear();
            txtHakusana.Clear();
            cbKriteeri.SelectedIndex = 0;
        }

        //Lisää/Muokkaa-tab
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            //Tietoja ei voida päivittää tai tallentaa jos yksikin kenttä on tyhjänä
            if (string.IsNullOrEmpty(txtNimi.Text) || string.IsNullOrEmpty(txtLahiosoite.Text) || string.IsNullOrEmpty(txtPostitoimipaikka.Text) ||
                string.IsNullOrEmpty(txtPostinro.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPuhnro.Text))
            {
                MessageBox.Show("Kentät eivät voi olla tyhjiä");
            }
            else
            {
                try
                {
                    //Muokkaus-nappia ei ole painettu, eli tallentaa uudet tiedot
                    if (muokkaus == false)
                    {
                        yhteys.Suorita("INSERT INTO toimipiste (nimi, lahiosoite, postitoimipaikka, postinro, email, puhelinnro) VALUES ('" +
                            txtNimi.Text + "', '" + txtLahiosoite.Text + "', '" + txtPostitoimipaikka.Text + "', '" +
                            txtPostinro.Text + "', '" + txtEmail.Text + "', '" + txtPuhnro.Text + "')");
                    }
                    //Muokkaa-nappia painettu, eli muokkaa tallenettuja tietoja
                    else
                    {
                        yhteys.Suorita("UPDATE toimipiste SET nimi='" + txtNimi.Text + "', lahiosoite='" + txtLahiosoite.Text + "', postitoimipaikka='" +
                            txtPostitoimipaikka.Text + "', postinro='" + txtPostinro.Text + "', email='" + txtEmail.Text + "', puhelinnro='" + txtPuhnro.Text +
                            "' WHERE toimipiste_id=" + valittu + ";");
                    }
                    ReloadForm();
                    tcToimipisteet.SelectedIndex = 0; //Vaihtaa tabia
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Tyhjentää kentät
        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            ReloadForm();
            tcToimipisteet.SelectedIndex = 0;
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            if (dgToimipisteet.SelectedCells.Count > 0)
            {
                try
                {
                    muokkaus = true;
                    valittu = dgToimipisteet.Rows[dgToimipisteet.CurrentRow.Index].Cells[0].Value.ToString();

                    DataRow drvalinta = yhteys.HaeTiedot("SELECT * FROM toimipiste WHERE toimipiste_id='" + valittu + "'").Rows[0];

                    txtNimi.Text = drvalinta.ItemArray.GetValue(1).ToString();
                    txtLahiosoite.Text = drvalinta.ItemArray.GetValue(2).ToString();
                    txtPostitoimipaikka.Text = drvalinta.ItemArray.GetValue(3).ToString();
                    txtPostinro.Text = drvalinta.ItemArray.GetValue(4).ToString();
                    txtEmail.Text = drvalinta.ItemArray.GetValue(5).ToString();
                    txtPuhnro.Text = drvalinta.ItemArray.GetValue(6).ToString();

                    tcToimipisteet.SelectedIndex = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Virhe");
                }
            }
            else
            {
                MessageBox.Show("Toimipistettä ei ole valittu.");
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (dgToimipisteet.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Haluatko varmasti poistaa toimipisteen järjestelmästä?" + Environment.NewLine +
                    "HUOM! Tämä poistaa myös kaikki toimipisteen varaukset, palvelut sekä laskut!", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        valittu = dgToimipisteet.Rows[dgToimipisteet.CurrentRow.Index].Cells[0].Value.ToString();
                        yhteys.Suorita("DELETE FROM toimipiste WHERE toimipiste_id='" + valittu + "'");

                        ReloadForm();
                        MessageBox.Show("Toimipiste poistettu");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Virhe");
                    }
                }
            }
            else
            {
                MessageBox.Show("Toimipistettä ei ole valittu.");
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHakusana.Text))
            {
                MessageBox.Show("Kirjoita hakusana");
            }
            //Kriteeriä ei ole valittu = hakee kaikista kentistä hakusanalla
            else if (txtHakusana.Text.Length > 0 && cbKriteeri.SelectedValue.Equals("0"))
            {
                dttoimipisteet = yhteys.HaeTiedot("SELECT toimipiste_id AS 'ID', nimi AS 'Nimi', lahiosoite AS 'Lahiosoite', " +
                    "postitoimipaikka AS 'Postitoimipaikka', postinro AS 'Postinumero', email AS 'E-mail', puhelinnro AS 'Puh. nro' FROM toimipiste WHERE " +
                    "nimi LIKE '%" + txtHakusana.Text + "%' OR lahiosoite LIKE '%" + txtHakusana.Text + "%' OR postitoimipaikka LIKE '%" + txtHakusana.Text + "%'" +
                    " OR postinro LIKE '%" + txtHakusana.Text + "%' OR email LIKE '%" + txtHakusana.Text + "%' OR puhelinnro LIKE '%" + txtHakusana.Text + "%';");
                dgToimipisteet.DataSource = null;
                dgToimipisteet.DataSource = dttoimipisteet;
            }
            //Kriteeri valittu = hakee valitusta kriteeristä hakusanalla
            else if (txtHakusana.Text.Length > 0)
            {
                dttoimipisteet = yhteys.HaeTiedot("SELECT toimipiste_id AS 'ID', nimi AS 'Nimi', lahiosoite AS 'Lahiosoite', " +
                    "postitoimipaikka AS 'Postitoimipaikka', postinro AS 'Postinumero', email AS 'E-mail', puhelinnro AS 'Puh. nro' FROM toimipiste WHERE " +
                    cbKriteeri.SelectedValue + " LIKE '%" + txtHakusana.Text + "%';");
                dgToimipisteet.DataSource = null;
                dgToimipisteet.DataSource = dttoimipisteet;
            }
        }
    }
}
