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
    public partial class Raportit : Form
    {

        private DBConnect yhteys;
        private DataTable dtraportti, dtyhteenveto;
        private DataTable dttoimipisteet;

        // Näitä käytetään eri raporttien haun rajaamiseen eri palvelutyyppien mukaisesti.
        Dictionary<string, string> hakuKriteerit = new Dictionary<string, string>
        {   
            {"Majoituspalvelut", "1"},
            {"Lisäpalvelut", "2"},
        };

        public Raportit()
        {
            InitializeComponent();
            yhteys = new DBConnect();
            ReloadForm();
        }

        private void ReloadForm()
        {
            // Alustetaan toimipisteen valintaa varten dropdown-valikkoon eri toimipisteet kannasta.
            dttoimipisteet = yhteys.HaeTiedot("SELECT toimipiste_id, nimi FROM toimipiste");
            cbToimipiste.DataSource = null;
            cbToimipiste.DataSource = dttoimipisteet;
            cbToimipiste.DisplayMember = "nimi";
            cbToimipiste.ValueMember = "toimipiste_id";

            // Alustetaan palvelutyyppien haun comboboxia varten sille arvot hakuKriteerit-dictionarysta.
            cbTyyppi.DataSource = null;
            cbTyyppi.DataSource = new BindingSource(hakuKriteerit, null);
            cbTyyppi.DisplayMember = "Key";
            cbTyyppi.ValueMember = "Value";
        }

        private void btnPalauta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHae_Click(object sender, EventArgs e)
        {
            // Hakuehtojen päivämäärien muokkaus SQL:n ymmärtämään muotoon.
            string alarajapvm = dtpAlkaen.Value.Date.ToString("yyyyMMdd");
            string ylarajapvm = dtpPaattyen.Value.Date.ToString("yyyyMMdd");


            if (dtpAlkaen.Value >= dtpPaattyen.Value)
            {
                string message = "Haun alkupäivämäärän on oltava aiemmin kuin päättymispäivän.";
                MessageBox.Show(message);
            }
            else
            {
                /*
                 * Valitsee hakuja varten haun alkupäivän jos se on suurempi kuin varauksen alkupäivän
                 * ja haun loppupäivän jos se on pienempi kuin varauksen loppupäivä. Näin saadaan raportteja
                 * varten rajattua päivämäärät hakuehtojen mukaan. Esimerkiksi jos varaus kestää 1.4-6.4.,
                 * ja haun yläraja on 4.4., katkaisee tämä haun juuri siihen 4.4. ja varaukselta näytetään raportissa
                 * kestoksi 1.4.-4.4.
                 */
                string alarajaehto = "IF(v.varattu_alkupvm > " + alarajapvm + ", v.varattu_alkupvm, " + alarajapvm + ")";
                string ylarajaehto = "IF(v.varattu_loppupvm < " + ylarajapvm + ", v.varattu_loppupvm, " + ylarajapvm + ")";

                // Hakukenttien asettamat ehdot.
                string hakuehdot = "WHERE t.toimipiste_id = " + cbToimipiste.SelectedValue + " " +
                    "AND p.tyyppi = " + cbTyyppi.SelectedValue + " " +
                    "AND v.varattu_loppupvm >= " + alarajapvm + " " +
                    "AND v.varattu_alkupvm <= " + ylarajapvm;



                // Varsinainen raportti jossa näkyvät kaikki hakuehtojen mukaiset varaukset.
                dtraportti = yhteys.HaeTiedot("SELECT v.varaus_id as ID, " +
                    "CONCAT(a.etunimi, ' ', a.sukunimi) AS Asiakas, " +
                    "t.nimi AS Toimipiste, " +
                    "CASE WHEN p.tyyppi = 1 THEN 'Majoitus' " +
                    "WHEN p.tyyppi = 2 then 'Lisäpalvelu' " +
                    "END AS Palvelutyyppi, " +
                    "p.nimi AS Palvelu, " +
                    "p.hinta AS Kappalehinta, " +
                    "p.hinta * DATEDIFF(" + ylarajaehto + ", " + alarajaehto + ") AS Hinta, " +
                    "DATE_FORMAT(" + alarajaehto + ", '%d.%m.%Y') AS Aloituspvm, " +
                    "DATE_FORMAT(" + ylarajaehto + ", '%d.%m.%Y') AS Lopetuspvm, " +
                    "DATEDIFF(" + ylarajaehto + ", " + alarajaehto + ") AS Kesto " +
                    "FROM varaus v JOIN toimipiste t " +
                    "ON v.toimipiste_id = t.toimipiste_id " +
                    "JOIN asiakas a " +
                    "ON a.asiakas_id = v.asiakas_id " +
                    "JOIN varauksen_palvelut vp " +
                    "ON vp.varaus_id = v.varaus_id " +
                    "JOIN palvelu p " +
                    "ON p.palvelu_id = vp.palvelu_id " +
                    hakuehdot + " " +
                    "AND DATEDIFF(" + ylarajaehto + ", " + alarajaehto + ") > 0;"   // Poistetaan nollan yön mittaiset varaukset raportilta.
                    );

                dgRaportti.DataSource = null;
                dgRaportti.DataSource = dtraportti;

                // Yhteenvetoraportti
                dtyhteenveto = yhteys.HaeTiedot("SELECT t.nimi AS Toimipiste, " +
                    "CASE WHEN p.tyyppi = 1 THEN 'Majoitus' " +
                    "WHEN p.tyyppi = 2 then 'Lisäpalvelu' " +
                    "END AS Palvelutyyppi, " +
                    "SUM(p.hinta * DATEDIFF(" + ylarajaehto + ", " + alarajaehto + ")) AS 'Hinnat yht.', " +
                    "SUM(DATEDIFF(" + ylarajaehto + ", " + alarajaehto + ")) AS 'Kesto yht.' " +
                    "FROM varaus v JOIN toimipiste t " +
                    "ON v.toimipiste_id = t.toimipiste_id " +
                    "JOIN asiakas a " +
                    "ON a.asiakas_id = v.asiakas_id " +
                    "JOIN varauksen_palvelut vp " +
                    "ON vp.varaus_id = v.varaus_id " +
                    "JOIN palvelu p " +
                    "ON p.palvelu_id = vp.palvelu_id " +
                    hakuehdot + ";"
                    );

                dgYhteenveto.DataSource = null;
                dgYhteenveto.DataSource = dtyhteenveto;
            }
        }
    }
}
