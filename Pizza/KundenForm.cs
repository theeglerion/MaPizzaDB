using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizza
{
    public partial class KundenForm : Form
    {
        Datenbank db;
        List<Kunde> liKunde;

        public KundenForm()
        {
            InitializeComponent();
        }

        private void KundenForm_Load(object sender, EventArgs e)
        {
            db = new Datenbank();
            fuelleKunden();
            gbKunde.Enabled = false;
            
        }

        private void KundenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseDB();
        }

        private void fuelleKunden()
        {
            liKunde = db.GetKunden();
            lbKunden.Items.Clear();

            foreach(Kunde k in liKunde)
            {
                lbKunden.Items.Add(k.KdnName1 + "\t" + k.KdnTelefon1);
            }
        }

        private void tbClear()
        {
            tbKdnNr.Clear();
            tbKdnName.Clear();
            tbKdnEmail.Clear();
            tbKdnTelefon.Clear();
            tbKdnStrasse.Clear();
            tbKdnPLZ.Clear();
            tbKdnOrt.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbKunden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKunden.SelectedIndex != -1)
            {
                tbKdnNr.Text        = liKunde[lbKunden.SelectedIndex].KdnNr1.ToString();
                tbKdnName.Text      = liKunde[lbKunden.SelectedIndex].KdnName1.ToString();
                tbKdnEmail.Text     = liKunde[lbKunden.SelectedIndex].KdnEmail1.ToString();
                tbKdnTelefon.Text   = liKunde[lbKunden.SelectedIndex].KdnTelefon1.ToString();
                tbKdnStrasse.Text   = liKunde[lbKunden.SelectedIndex].KdnStrassenNr1.ToString();
                tbKdnOrt.Text       = liKunde[lbKunden.SelectedIndex].KdnOrt1.ToString();
                tbKdnPLZ.Text       = liKunde[lbKunden.SelectedIndex].KdnPLZ1.ToString();                
            }
            btnNewKunde.Enabled = true;
            gbKunde.Enabled = true;
            btnUpdateKunde.Enabled = true;
        }

        private void btnNewKunde_Click(object sender, EventArgs e)
        {
            tbClear();
            tbKdnNr.Text = "-1";
            gbKunde.Enabled = true;
            btnNewKunde.Enabled = false;
        }

        private void btnUpdateKunde_Click(object sender, EventArgs e)
        {
            Kunde k = new Kunde(
                    Convert.ToInt32(tbKdnNr.Text),
                    tbKdnName.Text,
                    tbKdnEmail.Text,
                    tbKdnTelefon.Text,
                    tbKdnStrasse.Text,
                    tbKdnPLZ.Text,
                    tbKdnOrt.Text
                );

            if (k.KdnNr1 != -1)
                db.UpdateKunden(k);
            else
            {
                db.InsertKunde(k);
                tbClear();
            }

            liKunde = db.GetKunden();
            lbKunden.Items.Clear();

            fuelleKunden();
            btnUpdateKunde.Enabled = false;
            gbKunde.Enabled = false;
            btnNewKunde.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Kunde k = new Kunde(
                Convert.ToInt32(tbKdnNr.Text),
                tbKdnName.Text,
                tbKdnEmail.Text,
                tbKdnTelefon.Text,
                tbKdnStrasse.Text,
                tbKdnPLZ.Text,
                tbKdnOrt.Text
            );
            
            db.DeleteKunde(k);
            
            liKunde = db.GetKunden();
            lbKunden.Items.Clear();
            tbClear();
            fuelleKunden();
        }
    }
}
