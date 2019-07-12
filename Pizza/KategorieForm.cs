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
    public partial class KategorieForm : Form
    {
        Datenbank db = new Datenbank();

        public KategorieForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KategorieForm_Load(object sender, EventArgs e)
        {
            
        }

        private void KategorieForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.CloseDB();
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            db.InsertKategorie(tbKategorie.Text);
            Close();
        }
    }
}
