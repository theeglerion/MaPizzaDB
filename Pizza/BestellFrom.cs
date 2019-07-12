using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizza
{
    public partial class BestellFrom : Form
    {
        Datenbank       db;
        ExcelDB         excl;
        List<Kunde>     liKunden;
        List<Speisen>   liSpeisen;
        List<double>    liSumme;
        int             bestellnr = -1;
        double          gesammt;


        public BestellFrom()
        {            
            InitializeComponent();
            db = new Datenbank();
            excl = new ExcelDB();
            liSumme = new List<double>();

            liKunden = db.GetKunden();
            foreach (Kunde k in liKunden)
            {
                cbBestellKunden.Items.Add(k.KdnNr1 + "\t" + k.KdnName1);
            }            

            liSpeisen = db.GetSpeisen();
            foreach (Speisen s in liSpeisen)
            {
                cbSpeisen.Items.Add(s.SNr + " " + s.SBezeichnung + " " + s.SKategorie + " " + s.SPreis);
            }
        }

        private void BestellFrom_Load(object sender, EventArgs e)
        {
            btnNewBestellung.Enabled = false;
        }

        private void BestellFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseDB();
        }

        private void FillUpKunden()
        {
            liKunden = db.GetKunden();
            cbBestellKunden.Items.Clear();

            foreach (Kunde k in liKunden)
            {
                cbBestellKunden.Items.Add(k.KdnNr1 + "\t" + k.KdnName1);
            }

            cbBestellKunden.Refresh();
        }

        private void btnNeuerKunde_Click(object sender, EventArgs e)
        {
            KundenForm kf = new KundenForm();
            kf.ShowDialog();
            FillUpKunden();
        }

        private void btnNewBestellung_Click(object sender, EventArgs e)
        {
            
            tbBestellDatum.Text = DateTime.Now.ToString();
            int knr = liKunden[cbBestellKunden.SelectedIndex].KdnNr1;
            if (knr < 1)
            {
                MessageBox.Show("Bitte Kunden auswählen!");
            }
            else
            {
                Bestellung b = new Bestellung(-1, tbBestellDatum.Text, knr);

                bestellnr = db.InsertBestellung(b);

                tbBestellNr.Text = bestellnr.ToString();
            }
        }

        private void cbBestellKunden_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNewBestellung.Enabled = true;
        }

        private void btnHinzu_Click(object sender, EventArgs e)
        {
            int menge;
            bool b = int.TryParse(tbMenge.Text, out menge);
            if (!b)
            {
                MessageBox.Show("Bitte Zahl in Menge eintagen!");
            }
            else
            {
                double summe = liSpeisen[cbSpeisen.SelectedIndex].SPreis * menge;
                liSumme.Add(summe);

                lbPositionen.Items.Add( liSpeisen[cbSpeisen.SelectedIndex].SBezeichnung.ToString() + "\t" +
                                        liSpeisen[cbSpeisen.SelectedIndex].SKategorie.ToString() + "\t" +
                                        "x " + menge.ToString() + "\t" +
                                        summe.ToString("#0.00") + " EUR");
                gesammt = gesammt + summe;

                tbPreis.Text = gesammt.ToString("#0.00") + " EUR";

                db.InsertPosition(new Position(liSpeisen[cbSpeisen.SelectedIndex].SNr,
                                             menge, bestellnr));
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            gesammt = gesammt - liSumme[lbPositionen.SelectedIndex];
            liSumme.RemoveAt(lbPositionen.SelectedIndex);
            lbPositionen.Items.RemoveAt(lbPositionen.SelectedIndex);
            lbPositionen.Refresh();
            tbPreis.Text = gesammt.ToString("#0.00") + " EUR";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBestellen_Click(object sender, EventArgs e)
        {
            lbPositionen.ClearSelected();
        }
    }
}
