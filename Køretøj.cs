//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BilletLibrary
//{
//    public abstract class Køretøj
//    {
//        private string _nummerplade;

//        public DateTime Dato { get; set; }

//        public bool BroBizz { get; set; }

//        public string NummerPlade
//        {
//            get
//            {
//                if (_nummerplade.Length > 7)
//                {
//                    throw new Exception("Nummerpladen kan ikke være længere end 7 tegn");
//                }
//                else
//                {
//                    return _nummerplade;
//                }
//            }
//            set { _nummerplade = value; }
//        }

//        public abstract decimal Pris();

//        public abstract string KøretøjsType();

//        public Køretøj(string nummerplade, DateTime dato)
//        {
//            _nummerplade = nummerplade;
//            Dato = dato;
//            BroBizz = false;
            
//        }


        


//    }
//}
