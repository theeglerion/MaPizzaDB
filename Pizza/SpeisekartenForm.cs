using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pizza
{
    public partial class SpeisekartenForm : Form
    {
        Datenbank db;
        List<Speisen> liSpeisen = new List<Speisen>();
        List<Speisen> liResults = new List<Speisen>();
        List<Kategorie> liKategorie = new List<Kategorie>();

        public SpeisekartenForm()
        {
            InitializeComponent();
        }

        private void SpeisekartenForm_Load(object sender, EventArgs e)
        {
            db = new Datenbank();

            FillUpSpeisekarte();
            FillUpKategorie();

            btnSenden.Enabled = false;
            btnDelete.Enabled = false;
            btnDelKat.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SpeisekartenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseDB();
        }

        private void FilterKategorie()
        {
            liResults.Clear();
            lbSpeisen.Items.Clear();

            btnSenden.Enabled = true;
            btnDelKat.Enabled = true;

            var selected =
                from i in liSpeisen
                where i.SKategorie.Equals(liKategorie[cbKategorie.SelectedIndex].KatNr1)
                select i;

            if (selected.Any())
            {
                foreach (var s in selected)
                {
                    liResults.Add(s);
                    lbSpeisen.Items.Add(s.SNr + "\t" +
                                        s.SBezeichnung + "\t" +
                                        s.SKategorie + "\t" +
                                        s.SPreis.ToString("F") + "\t" + "€"
                                        );
                }
            }
            else
            {
                lbSpeisen.Items.Add("Nicht gefunden oder leer!");
            }
        } 

        private void FillUpSpeisekarte()
        {
            liSpeisen = db.GetSpeisen();
            lbSpeisen.Items.Clear();

            foreach(Speisen s in liSpeisen)
            {
                liResults.Add(s);
                lbSpeisen.Items.Add(s.SNr + "\t" +
                                    s.SBezeichnung + "\t" +
                                    s.SKategorie + "\t" +
                                    s.SPreis.ToString("F") + "\t" + "€"
                                    );
            }
        }

        private void FillUpKategorie()
        {
            liKategorie.Clear();
            liKategorie = db.GetKategorie();
            cbKategorie.Items.Clear();

            foreach(Kategorie k in liKategorie)
            {
                cbKategorie.Items.Add(k.KatNr1 + "\t" + k.KatBezeichnung1);
            }
        }

        private void cbKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterKategorie();
        }

        private void lbSpeisen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSpeisen.SelectedIndex != -1)
            {
                tbNummer.Text       = liResults[lbSpeisen.SelectedIndex].SNr.ToString();
                tbBescheibung.Text  = liResults[lbSpeisen.SelectedIndex].SBezeichnung.ToString();
                tbPreis.Text        = liResults[lbSpeisen.SelectedIndex].SPreis.ToString();
            }
            if (cbKategorie.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
         
            if (double.TryParse(tbPreis.Text, out double dResult) &&
                int.TryParse(tbNummer.Text, out int iResult))
            {
                double d = dResult;
                Speisen s = new Speisen(iResult,
                                        tbBescheibung.Text,
                                        liKategorie[cbKategorie.SelectedIndex].KatNr1,
                                        d);
                
                db.InsertSpeise(s);
                FillUpSpeisekarte();
                FilterKategorie();
            }
            else
            {
                MessageBox.Show("Bitte Preis (xx,xx) eingeben und/oder Kategorie festlegen!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbSpeisen.SelectedIndex != -1)
            {
                Speisen s = new Speisen(
                    Convert.ToInt32(tbNummer.Text),
                    tbBescheibung.Text,
                    liKategorie[cbKategorie.SelectedIndex].KatNr1,
                    Convert.ToDouble(tbPreis.Text));

                db.DeleteSpiese(s);
                liSpeisen = db.GetSpeisen();
                FillUpSpeisekarte();
                btnDelete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bitte Produkt auswählen!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbSpeisen.SelectedIndex != -1 && cbKategorie.SelectedIndex != -1)
            {
                Speisen s = new Speisen(
                    Convert.ToInt32(tbNummer.Text),
                    tbBescheibung.Text,
                    liKategorie[cbKategorie.SelectedIndex].KatNr1,
                    Convert.ToDouble(tbPreis.Text));

                db.UpdateSpeise(s);
                liSpeisen.Clear();
                FillUpSpeisekarte();
                liResults = liSpeisen;
            }
            else
            {
                MessageBox.Show("Bitte Produkt und Kategorie auswählen!");
            }
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            KategorieForm kf = new KategorieForm();
            kf.ShowDialog();
            FillUpKategorie();
        }

        private void btnDelKat_Click(object sender, EventArgs e)
        {
            if (cbKategorie.SelectedIndex != -1)
            {
                Kategorie k = new Kategorie(liKategorie[cbKategorie.SelectedIndex].KatNr1,
                                            liKategorie[cbKategorie.SelectedIndex].KatBezeichnung1);
                db.DeleteKategorie(k);
                cbKategorie.Text = "";
                FillUpKategorie();
            }
        }
    }
}
