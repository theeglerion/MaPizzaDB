using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Bestellung
    {
        int BestNr;
        string BestDatum;
        int BestKunde;

        public Bestellung (int bNr, string bDatum, int bKunde)
        {
            BestNr = bNr;
            BestDatum = bDatum;
            BestKunde = bKunde;
        }

        public int BestNr1 { get => BestNr; set => BestNr = value; }
        public string BestDatum1 { get => BestDatum; set => BestDatum = value; }
        public int BestKunde1 { get => BestKunde; set => BestKunde = value; }
    }
}
