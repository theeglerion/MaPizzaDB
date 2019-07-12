using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Kunde
    {
        int    KdnNr;
        string KdnName;
        string KdnEmail;
        string KdnTelefon;
        string KdnStrassenNr;
        string KdnPLZ;
        string KdnOrt;


        public Kunde(int kNr, string kName, string kEmail, string kTelefon, string kStrasseNr, string kPLZ, string kOrt)
        {
            KdnNr           = kNr;
            KdnName         = kName;
            KdnEmail        = kEmail;
            KdnTelefon      = kTelefon;
            KdnStrassenNr   = kStrasseNr;
            KdnPLZ          = kPLZ;
            KdnOrt          = kOrt;
        }

        public int KdnNr1 { get => KdnNr; set => KdnNr = value; }
        public string KdnName1 { get => KdnName; set => KdnName = value; }
        public string KdnEmail1 { get => KdnEmail; set => KdnEmail = value; }
        public string KdnTelefon1 { get => KdnTelefon; set => KdnTelefon = value; }
        public string KdnStrassenNr1 { get => KdnStrassenNr; set => KdnStrassenNr = value; }
        public string KdnPLZ1 { get => KdnPLZ; set => KdnPLZ = value; }
        public string KdnOrt1 { get => KdnOrt; set => KdnOrt = value; }
    }
}
