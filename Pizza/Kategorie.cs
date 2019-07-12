using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Kategorie
    {
        int KatNr;
        string KatBezeichnung;

        public Kategorie(int katNr, string katBezeichnung)
        {
            KatNr = katNr;
            KatBezeichnung = katBezeichnung;
        }

        public int KatNr1 { get => KatNr; set => KatNr = value; }
        public string KatBezeichnung1 { get => KatBezeichnung; set => KatBezeichnung = value; }
    }
}
