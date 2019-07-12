using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Position
    {
        int PosSpeise;
        int PosMenge;
        int PosBestellung;


        public Position(int pSpeise, int pMenge, int pBestellung)
        {
            PosSpeise1       = pSpeise;
            PosMenge1        = pMenge;
            PosBestellung1   = pBestellung;
        }

        public int PosSpeise1 { get => PosSpeise; set => PosSpeise = value; }
        public int PosMenge1 { get => PosMenge; set => PosMenge = value; }
        public int PosBestellung1 { get => PosBestellung; set => PosBestellung = value; }
    }
}
