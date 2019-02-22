using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        public override decimal Pris()
        {
            if (BroBizz == true)
            {
                return 125 * 0.05M;
            }
            return 125;
        }

        public override string KøretøjsType()
        {
            return "MC";
        }

        public MC(string nummerplade, DateTime dato)
            :base(nummerplade, dato)
        {
            nummerplade = NummerPlade;
            Dato = dato;
        }
    }
}
