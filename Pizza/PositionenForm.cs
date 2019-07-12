using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{   
    public partial class PositionenForm : Form
    {
        Datenbank db;
        List<View> liView = new List<View>();
        List<View> liResults = new List<View>(); 

        public PositionenForm()
        {
            InitializeComponent();
        }

        private void PositionenForm_Load(object sender, EventArgs e)
        {
            db = new Datenbank();

            FillUpPositionen();
            rbBestell.Checked = true;
        }

        private void FillUpPositionen()
        {
            liView = db.ViewBestellung();
            liResults = db.ViewBestellung();
            lbPos.Items.Clear();

            foreach (View v in liView)
            {
                double summe = v.VSpPreis * v.VPosMenge;

                lbPos.Items.Add(v.VBestNr + "\t" + 
                                v.VBestDatum + "\t" +
                                v.VSpBezeichnung + "\t" +
                                v.VPosMenge + "\t" +
                                v.VSpPreis + "\t" +
                                v.VKdnName + "\t" +
                                v.VKdnTelefon + "\t" +
                                v.VKdnStrasseNr + "\t" +
                                v.VKdnPLZ +"\t" +
                                v.VKdnOrt + "\t" +
                                summe.ToString("F") + "\t€"
                                );
            }
        }

        private void PositionenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseDB();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)        //the event shows elemets from a list that
        {                                                               //are containing an in 'tbSearch' inserted string
            lbPos.Items.Clear();
            liResults.Clear();

            IEnumerable<View> selected = null;

            if (rbBestell.Checked)
            {
                selected =
                    from i in liView
                    where i.VBestNr.ToString().Contains(tbSearch.Text)
                    select i;
            }
            else if (rbTele.Checked)
            {
                selected =
                    from i in liView
                    where i.VKdnTelefon.ToString().Contains(tbSearch.Text)
                    select i;
            }
            else if (rbDate.Checked)
            {
                selected =
                    from i in liView
                    where i.VBestDatum.Contains(tbSearch.Text)
                    select i;
            }

            foreach (var v in selected)
            {
                double summe = v.VSpPreis * v.VPosMenge;

                liResults.Add(v);

                lbPos.Items.Add(v.VBestNr + "\t" +
                                v.VBestDatum + "\t" +
                                v.VSpBezeichnung + "\t" +
                                v.VPosMenge + "\t" +
                                v.VSpPreis + "\t" +
                                v.VKdnName + "\t" +
                                v.VKdnTelefon + "\t" +
                                v.VKdnStrasseNr + "\t" +
                                v.VKdnPLZ + "\t" +
                                v.VKdnOrt + "\t" +
                                summe.ToString("F") + "\t€"
                                );
            }

            if (!selected.Any())
            {
                MessageBox.Show("Nichts gefunden oder leer!");
            }
        }

        private void lbPos_SelectedIndexChanged(object sender, EventArgs e) //The event shows the sum price of all 
        {
            lbPos.Refresh();
            double summe = 0;
            string test = lbPos.SelectedItem.ToString().Substring(0, 2);

            foreach (View v in liResults)
            {
                if (v.VBestNr == liResults[lbPos.SelectedIndex].VBestNr)
                {
                    summe = summe + (v.VPosMenge * v.VSpPreis);
                }
            }
            tbSumme.Text = summe.ToString("F");          
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AcceptButton = this.btnSearch;
            }
        }
    }
}