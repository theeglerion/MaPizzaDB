namespace Pizza
{
    public class Speisen
    {
        int sNr;
        string sBezeichnung;
        int sKategorie;
        double sPreis;

        public Speisen(int SpNr, string SpBez, int SpKategorie, double SpPreis)
        {
            SNr = SpNr;
            SBezeichnung = SpBez;
            SKategorie = SpKategorie;
            SPreis = SpPreis;
        }

        public int SNr { get => sNr; set => sNr = value; }
        public string SBezeichnung { get => sBezeichnung; set => sBezeichnung = value; }
        public int SKategorie { get => sKategorie; set => sKategorie = value; }
        public double SPreis { get => sPreis; set => sPreis = value; }
    }
}