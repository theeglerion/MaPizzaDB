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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKunde_Click(object sender, EventArgs e)
        {
            KundenForm kf = new KundenForm();
            kf.ShowDialog();
        }
               
        private void BtnBestellungen_Click(object sender, EventArgs e)
        {
            BestellFrom bf = new BestellFrom();
            bf.ShowDialog();
        }

        private void BtnPositionen_Click(object sender, EventArgs e)
        {
            PositionenForm pf = new PositionenForm();
            pf.ShowDialog();
        }


        private void BtnSpeisekarte_Click(object sender, EventArgs e)
        {
            SpeisekartenForm sf = new SpeisekartenForm();
            sf.ShowDialog();
        }
    }
}
