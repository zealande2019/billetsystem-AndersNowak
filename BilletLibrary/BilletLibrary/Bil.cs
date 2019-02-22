using System;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {

        public override decimal Pris()
        {
            if (BroBizz == true)
            {
                return 240 * 0.05M;
            }
            return 240;
        }

        public override string KøretøjsType()
        {
            return "Bil";
        }

        public Bil(string nummerplade, DateTime dato)
            : base(nummerplade, dato)
        {
            nummerplade = NummerPlade;
            Dato = dato;
        }

    }
}
