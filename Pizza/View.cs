using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class View
    {
        int     vBestNr;
        string  vBestDatum;
        string  vSpBezeichnung;
        double  vSpPreis;
        int     vPosMenge;
        string  vKdnName;
        string  vKdnTelefon;
        string  vKdnStrasseNr;
        string  vKdnPLZ;
        string  vKdnOrt;

        public View (   int    vNr, 
                        string vDate, 
                        string vBez, 
                        double vPreis, 
                        int    vMenge, 
                        string vName,
                        string vTelefon,
                        string vStrasse, 
                        string vPLZ, 
                        string vOrt
                    )
        {
            vBestNr         = vNr;
            vBestDatum      = vDate;
            vSpBezeichnung  = vBez;
            vSpPreis        = vPreis;
            vPosMenge       = vMenge;
            vKdnName        = vName;
            vKdnTelefon     = vTelefon;
            vKdnStrasseNr   = vStrasse;
            vKdnPLZ         = vPLZ;
            vKdnOrt         = vOrt;
        }

        public int VBestNr { get => vBestNr; set => vBestNr = value; }
        public string VBestDatum { get => vBestDatum; set => vBestDatum = value; }
        public string VSpBezeichnung { get => vSpBezeichnung; set => vSpBezeichnung = value; }
        public double VSpPreis { get => vSpPreis; set => vSpPreis = value; }
        public int VPosMenge { get => vPosMenge; set => vPosMenge = value; }
        public string VKdnName { get => vKdnName; set => vKdnName = value; }
        public string VKdnTelefon { get => vKdnTelefon; set => vKdnTelefon = value; }
        public string VKdnStrasseNr { get => vKdnStrasseNr; set => vKdnStrasseNr = value; }
        public string VKdnPLZ { get => vKdnPLZ; set => vKdnPLZ = value; }
        public string VKdnOrt { get => vKdnOrt; set => vKdnOrt = value; }
    }
}
