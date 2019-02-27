using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        public override double Pris()
        {
            if (BroBizz == true)
            {
                return 125 * 0.95;
            }
            return 125;
        }

        public override string KøretøjsType()
        {
            return "MC";
        }

        
    }
}
