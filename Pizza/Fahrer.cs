using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Fahrer
    {
        private int     fNr;
        private string  fVorname;
        private string  fNachname;
        private string  fKennzeichen;

        public Fahrer (int Nr, string Vorname, string Nachname, string KFZ)
        {
            fNr             = Nr;
            fVorname        = Vorname;
            fNachname       = Nachname;
            fKennzeichen    = KFZ;
        }

        public int FNr { get => fNr; set => fNr = value; }
        public string FVorname { get => fVorname; set => fVorname = value; }
        public string FNachname { get => fNachname; set => fNachname = value; }
        public string FKennzeichen { get => fKennzeichen; set => fKennzeichen = value; }
    }
}
