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
    public partial class Palvelut : Form
    {
        private DBConnect yhteys;
        private DataTable dtpalvelut;
        private DataTable dttoimipisteet; // Toimipaikkojen comboboxia varten
        private string valittu;
        private bool muokkaus = false;

        // hakuehtojen listaus
        Dictionary<string, string> hakuehdot = new Dictionary<string, string>
        {
            { "Ei valintaa", "0" },
            { "ID", "p.palvelu_id" },
            { "Nimi", "p.nimi" },
            {"Toimipiste", "t.nimi" },
            { "Tyyppi", "p.tyyppi" }
        };

        // pavelun tyyppien listaus
        Dictionary<string, string> palvelunTyypit = new Dictionary<string, string>
        {
            { "Majoitus", "1" },
            { "Muut palvelut", "2" }
        };

        public Palvelut()
        {
            InitializeComponent();
            yhteys = new DBConnect();
            ReloadForm();
        }

        private void ReloadForm()
        {
            try
            {
                dtpalvelut = yhteys.HaeTiedot("SELECT p.palvelu_id AS 'ID', p.nimi AS 'Nimi', t.nimi AS 'Toimipiste', " +
                    "CASE WHEN p.tyyppi = 1 THEN 'Majoitus' WHEN p.tyyppi = 2 THEN 'Muu palvelu' END AS 'Tyyppi', p.hinta AS 'Hinta', p.alv AS 'ALV', p.kuvaus AS 'Kuvaus' " +
                    "FROM palvelu p JOIN toimipiste t ON t.toimipiste_id = p.toimipiste_id ORDER BY p.palvelu_id");

                dgPalvelut.DataSource = null;
                dgPalvelut.DataSource = dtpalvelut;

                dttoimipisteet = yhteys.HaeTiedot("SELECT toimipiste_id, nimi FROM toimipiste");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tapahtui virhe");
            }

            // combobox toimipisteiden valintaan
            cbToimipiste.DataSource = null;
            cbToimipiste.DataSource = dttoimipisteet;
            cbToimipiste.DisplayMember = "nimi";
            cbToimipiste.ValueMember = "toimipiste_id";

            // combobox palvelun tyyppien valintaan
            cbTyyppi.DataSource = null;
            cbTyyppi.DataSource = new BindingSource(palvelunTyypit, null);
            cbTyyppi.DisplayMember = "Key";
            cbTyyppi.ValueMember = "Value";

            // combox hakuehtojen valintaan
            cbHakuehdot.DataSource = null;
            cbHakuehdot.DataSource = new BindingSource(hakuehdot, null);
            cbHakuehdot.DisplayMember = "Key";
            cbHakuehdot.ValueMember = "Value";

            muokkaus = false;
            txtNimi.Clear();
            txtHinta.Clear();
            txtAlv.Clear();
            txtKuvaus.Clear();
            txtHakusana.Clear();
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            string hintaMuutettu = txtHinta.Text.Replace(",", ".");
            string alvMuutettu = txtAlv.Text.Replace(",", ".");

            //Tietoja ei voida päivittää tai tallentaa jos yksikin kenttä on tyhjänä
            if (cbToimipiste.SelectedItem == null || string.IsNullOrEmpty(txtNimi.Text) || cbTyyppi.SelectedItem == null || hintaMuutettu == null || alvMuutettu == null || string.IsNullOrEmpty(txtKuvaus.Text))
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
                        yhteys.Suorita("INSERT INTO palvelu (toimipiste_id, nimi, tyyppi, hinta, alv, kuvaus) VALUES ('" +
                            cbToimipiste.SelectedValue + "', '" + txtNimi.Text + "', '" + cbTyyppi.SelectedValue + "', '" +
                            hintaMuutettu + "', '" + alvMuutettu + "', '" + txtKuvaus.Text + "')");
                    }
                    //Muokkaa-nappia painettu, eli muokkaa tallenettuja tietoja
                    else
                    {
                            yhteys.Suorita("UPDATE palvelu SET toimipiste_id='" + cbToimipiste.SelectedValue + "', nimi='" + txtNimi.Text + "', tyyppi='" +
                            cbTyyppi.SelectedValue + "', hinta='" + hintaMuutettu + "', alv='" + alvMuutettu + "', kuvaus='" + txtKuvaus.Text +
                            "' WHERE palvelu_id=" + valittu + ";");
                    }
                    ReloadForm();
                    tcPalvelut.SelectedIndex = 0; //Vaihtaa tabia
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
            tcPalvelut.SelectedIndex = 0;

        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            if (dgPalvelut.SelectedCells.Count > 0)
            {
                try
                {
                    muokkaus = true;
                    valittu = dgPalvelut.Rows[dgPalvelut.CurrentRow.Index].Cells[0].Value.ToString();

                    DataRow drvalinta = yhteys.HaeTiedot("SELECT * FROM palvelu WHERE palvelu_id='" + valittu + "'").Rows[0];

                    cbToimipiste.SelectedValue = drvalinta.ItemArray.GetValue(1);
                    txtNimi.Text = drvalinta.ItemArray.GetValue(2).ToString();
                    cbTyyppi.SelectedValue = drvalinta.ItemArray.GetValue(3).ToString();

                    txtKuvaus.Text = drvalinta.ItemArray.GetValue(4).ToString();
                    txtHinta.Text = drvalinta.ItemArray.GetValue(5).ToString();
                    txtAlv.Text = drvalinta.ItemArray.GetValue(6).ToString();

                    tcPalvelut.SelectedIndex = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Virhe");
                }
            }
            else
            {
                MessageBox.Show("Palvelua ei ole valittu.");
            }
        }

        private void btnPoista_Click(object sender, EventArgs e)
        {
            if (dgPalvelut.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Haluatko varmasti poistaa palvelun järjestelmästä?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        valittu = dgPalvelut.Rows[dgPalvelut.CurrentRow.Index].Cells[0].Value.ToString();
                        yhteys.Suorita("DELETE FROM palvelu WHERE palvelu_id='" + valittu + "'");

                        ReloadForm();
                        MessageBox.Show("Palvelu poistettu");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Virhe");
                    }
                }
            }
            else
            {
                MessageBox.Show("Palvelua ei ole valittu.");
            }
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHakusana.Text))
            {
                MessageBox.Show("Kirjoita hakusana");
            }
            else if (txtHakusana.Text.Length > 0 && cbHakuehdot.SelectedValue.Equals("0"))
            {
                dtpalvelut = yhteys.HaeTiedot("SELECT p.palvelu_id AS 'ID', p.nimi AS 'Nimi', t.nimi AS 'Toimipiste', " +
                    "CASE p.tyyppi WHEN 1 THEN 'Majoitus' WHEN 2 THEN 'Lisäpalvelu' END AS 'Tyyppi', p.hinta AS 'Hinta', p.alv AS 'ALV', p.kuvaus AS 'Kuvaus' " +
                    "FROM palvelu p JOIN toimipiste t ON t.toimipiste_id = p.toimipiste_id WHERE " +
                    "p.nimi LIKE '%" + txtHakusana.Text + "%' OR t.nimi LIKE '%" + txtHakusana.Text + "%' OR (CASE p.tyyppi WHEN 1 THEN 'Majoitus' WHEN 2 THEN 'Lisäpalvelu' END) LIKE '%" + txtHakusana.Text + "%';");

                dgPalvelut.DataSource = null;
                dgPalvelut.DataSource = dtpalvelut;
            }
            else if (txtHakusana.Text.Length > 0 && cbHakuehdot.SelectedValue.Equals("p.tyyppi"))
            {
                dtpalvelut = yhteys.HaeTiedot("SELECT p.palvelu_id AS 'ID', p.nimi AS 'Nimi', t.nimi AS 'Toimipiste', " +
                    "CASE p.tyyppi WHEN 1 THEN 'Majoitus' WHEN 2 THEN 'Lisäpalvelu' END AS 'Tyyppi', " +
                    "p.hinta AS 'Hinta', p.alv AS 'ALV', p.kuvaus AS 'Kuvaus' " +
                    "FROM palvelu p JOIN toimipiste t ON t.toimipiste_id = p.toimipiste_id " +
                    "WHERE (CASE p.tyyppi WHEN 1 THEN 'Majoitus' WHEN 2 THEN 'Lisäpalvelu' END) LIKE '%" + txtHakusana.Text + "%';");
                
                dgPalvelut.DataSource = null;
                dgPalvelut.DataSource = dtpalvelut;
            }
            else
            {
                dtpalvelut = yhteys.HaeTiedot("SELECT p.palvelu_id AS 'ID', p.nimi AS 'Nimi', t.nimi AS 'Toimipiste', " +
                   "CASE p.tyyppi WHEN 1 THEN 'Majoitus' WHEN 2 THEN 'Lisäpalvelu' END AS 'Tyyppi', " +
                   "p.hinta AS 'Hinta', p.alv AS 'ALV', p.kuvaus AS 'Kuvaus' " +
                   "FROM palvelu p JOIN toimipiste t ON t.toimipiste_id = p.toimipiste_id " +
                   "WHERE " + cbHakuehdot.SelectedValue + " LIKE '%" + txtHakusana.Text + "%';");

                dgPalvelut.DataSource = null;
                dgPalvelut.DataSource = dtpalvelut;
            }
            
        }
    }
}