using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        protected string _nummerplade;

        public DateTime Dato { get; set; }

        public bool BroBizz { get; set; }

        public string NummerPlade
        {
            get => _nummerplade;
            set
            {
                if (_nummerplade.Length > 7)
                {
                    throw new Exception("Nummerpladen kan ikke være længere end 7 tegn");
                }

            }
        }

        public abstract double Pris();

        public abstract string KøretøjsType();

        


        


    }
}
