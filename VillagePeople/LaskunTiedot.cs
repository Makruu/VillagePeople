using Apitron.PDF.Kit;
using Apitron.PDF.Kit.FixedLayout;
using Apitron.PDF.Kit.FixedLayout.PageProperties;
using Apitron.PDF.Kit.FixedLayout.Resources;
using Apitron.PDF.Kit.FixedLayout.Resources.Fonts;
using Apitron.PDF.Kit.FlowLayout.Content;
using Apitron.PDF.Kit.Styles;
using Apitron.PDF.Kit.Styles.Appearance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = Apitron.PDF.Kit.FlowLayout.Content.Image;

namespace VillagePeople
{
    public partial class LaskunTiedot : Form
    {
        private DBConnect yhteys;
        private DataRow drlasku;
        private DataTable dtpalvelut;
        private int laskuid;
        private string laskunpath;

        public LaskunTiedot(int lasku)
        {
            laskuid = lasku;
            InitializeComponent();
            yhteys = new DBConnect();
            LataaForm();
        }

        private void LataaForm()
        {
            try
            {
                drlasku = yhteys.HaeTiedot("SELECT * FROM lasku WHERE lasku_id='" + laskuid + "'").Rows[0];

                txtTiedot.Text = "Laskun tiedot:" + Environment.NewLine + "Laskun numero: " + drlasku.ItemArray.GetValue(0).ToString() +
                    Environment.NewLine + "Varausnumero: " + drlasku.ItemArray.GetValue(1).ToString() +
                    Environment.NewLine + "Päivämäärä: " + DateTime.Parse(drlasku.ItemArray.GetValue(2).ToString()).ToShortDateString() +
                    Environment.NewLine + Environment.NewLine + "Laskutusosoite: " + Environment.NewLine + drlasku.ItemArray.GetValue(3).ToString() +
                    Environment.NewLine + drlasku.ItemArray.GetValue(4).ToString() + Environment.NewLine + drlasku.ItemArray.GetValue(6).ToString() + " " +
                    drlasku.ItemArray.GetValue(5).ToString();

                dtpalvelut = yhteys.HaeTiedot("SELECT p.palvelu_id AS 'ID', p.nimi AS 'Nimi', p.kuvaus AS 'Kuvaus', p.hinta AS 'Hinta/pv', vp.lkm AS 'Pv', (p.hinta * vp.lkm) AS 'Yht' FROM " +
                "varauksen_palvelut vp JOIN palvelu p ON vp.palvelu_id = p.palvelu_id WHERE vp.varaus_id = '" + drlasku.ItemArray.GetValue(1).ToString() + "'");
                dgTiedot.DataSource = null;
                dgTiedot.DataSource = dtpalvelut;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tapahtui virhe");
            }
        }

        private void btnTulosta_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.pdf | *.pdf";
            dialog.RestoreDirectory = true;

            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    laskunpath = dialog.FileName;
                    GeneroiLasku(dialog.OpenFile());
                    System.Diagnostics.Process.Start(laskunpath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe laskun tallennuksessa, sulje avoin lasku ja yritä uudelleen.");
            }
        }

        private void GeneroiLasku(Stream strm)
        {
            FlowDocument lasku = new FlowDocument();
            lasku.StyleManager.RegisterStyle("gridrow.tableHeader", new Style() { Background = RgbColors.BurlyWood });
            lasku.StyleManager.RegisterStyle("gridrow.centerAlignedCells > *, gridrow > *.centerAlignedCell", new Style() { Align = Align.Center, Margin = new Thickness(0) });
            lasku.StyleManager.RegisterStyle("gridrow > *.leftAlignedCell", new Style() { Align = Align.Left, Margin = new Thickness(5, 0, 0, 0) });
            lasku.StyleManager.RegisterStyle("gridrow > *", new Style() { Align = Align.Right, Margin = new Thickness(0, 0, 5, 0) });

            ResourceManager rsmgr = new ResourceManager();
            rsmgr.RegisterResource(new Apitron.PDF.Kit.FixedLayout.Resources.XObjects.Image("logo", @"..\..\logo.png", true) { Interpolate = true });

            lasku.PageHeader.Margin = new Thickness(0, 40, 0, 20);
            lasku.PageHeader.Padding = new Thickness(10, 0, 10, 0);
            lasku.PageHeader.Height = 120;
            lasku.PageHeader.Background = RgbColors.BurlyWood;
            lasku.PageHeader.LineHeight = 60;
            lasku.PageHeader.Add(new Image("logo")
            {
                Height = 50,
                Width = 50,
                VerticalAlign = VerticalAlign.Middle
            });
            lasku.PageHeader.Add(new TextBlock("Village People Oy - Lasku")
            {
                Display = Display.InlineBlock,
                Align = Align.Left,
                Padding = new Thickness(10, 0, 0, 0),
                Font = new Apitron.PDF.Kit.Styles.Text.Font(StandardFonts.CourierBold, 20),
                Color = RgbColors.Black
            });

            Section laskunOsa = new Section() { Padding = new Thickness(20) };
            laskunOsa.AddItems(LisaaLaskunTiedot(new string[] { "Laskutusosoite: " + Environment.NewLine +
                drlasku.ItemArray.GetValue(3).ToString() + Environment.NewLine + drlasku.ItemArray.GetValue(4).ToString() +
                Environment.NewLine + drlasku.ItemArray.GetValue(6).ToString() + " " + drlasku.ItemArray.GetValue(5).ToString(),
                "Laskun tiedot:" + Environment.NewLine + "Laskun numero: " + drlasku.ItemArray.GetValue(0).ToString() + Environment.NewLine +
                "Varausnumero: " + drlasku.ItemArray.GetValue(1).ToString() + Environment.NewLine +
                "Päivämäärä: " + DateTime.Parse(drlasku.ItemArray.GetValue(2).ToString()).ToShortDateString() }));
            laskunOsa.Add(new Hr() { Padding = new Thickness(0, 20, 0, 20) });
            laskunOsa.Add(LuoPalvelutTaulukko());
            laskunOsa.Add(new Br { Height = 20 });
            laskunOsa.Add(new Section() { Width = 250, Display = Display.InlineBlock });

            lasku.Add(laskunOsa);
            lasku.Write(strm, rsmgr, new PageBoundary(Boundaries.A4));
            strm.Close();
        }

        private IList<Section> LisaaLaskunTiedot(string[] tiedot)
        {
            List<Section> osa = new List<Section>();
            double width = 100.0 / tiedot.Length;
            for (int i = 0; i < tiedot.Length; i++)
            {
                Section section = new Section()
                {
                    Width = Length.FromPercentage(width),
                    Display = Display.InlineBlock
                };
                using (StringReader reader = new StringReader(tiedot[i]))
                {
                    string currentLine = null;
                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        section.Add(new TextBlock(currentLine));
                        section.Add(new Br());
                    }
                }
                osa.Add(section);
            }
            return osa;
        }

        private Grid LuoPalvelutTaulukko()
        {
            Grid palvelutTaulukko = new Grid(30, Length.Auto, 40, 60, 70);
            palvelutTaulukko.Add(new GridRow(new TextBlock("ID"), new TextBlock("Palvelu"), new TextBlock("Pv"), new TextBlock("Hinta/pv"), new TextBlock("Yhteensä"))
            {
                Class = "tableHeader centerAlignedCells"
            });
            Decimal laskunSumma = 0;
            foreach (DataRow dr in dtpalvelut.Rows)
            {
                TextBlock id = new TextBlock(dr.ItemArray.GetValue(0).ToString()) { Class = "centerAlignedCell" };
                TextBlock palvelu = new TextBlock(dr.ItemArray.GetValue(1).ToString()) { Class = "leftAlignedCell" };
                TextBlock lkm = new TextBlock(dr.ItemArray.GetValue(4).ToString()) { Class = "centerAlignedCell" };
                TextBlock hinta = new TextBlock(dr.ItemArray.GetValue(3).ToString());
                TextBlock yht = new TextBlock(dr.ItemArray.GetValue(5).ToString());
                palvelutTaulukko.Add(new GridRow(id, palvelu, lkm, hinta, yht));
                laskunSumma += (Decimal)dr.ItemArray.GetValue(5);
            }

            palvelutTaulukko.Add(new GridRow(new TextBlock("Summa(EUR)") { ColSpan = 4 }, new TextBlock(laskunSumma.ToString(CultureInfo.InvariantCulture)) { ColSpan = 1 }));
            return palvelutTaulukko;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string laskuNimi = "villagepeople-" + DateTime.Now.Ticks + ".pdf";

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("insaniagames.com");

                mail.From = new MailAddress("villagepeople@insaniagames.com", "Village People Oy");
                mail.To.Add(new MailAddress(txtsposti.Text));
                mail.Subject = "Village People Oy Lasku";
                mail.Body = "Hei, tässä lasku." + Environment.NewLine + Environment.NewLine + "Village People Oy";

                using (FileStream fs = File.Create(Path.GetTempPath() + laskuNimi))
                {
                    GeneroiLasku(fs);
                    fs.Close();
                }
                mail.Attachments.Add(new Attachment(Path.GetTempPath() + laskuNimi));

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("villagepeople", "bm7xzaVrCqNPebgU");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Posti lähetetty");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Tarkista sähköposti", "Virhe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
