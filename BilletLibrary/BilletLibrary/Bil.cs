using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {

        public override double Pris()
        {
            if (BroBizz == true)
            {
                return 240 * 0.95;
            }
            return 240;
        }

        public override string KøretøjsType()
        {
            return "Bil";
        }

        

    }
}
