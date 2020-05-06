using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_Metody
{
    class Zwierze
    {

        private string _nazwa;
        private string _nazwa2;
        private readonly string _readonly;

        public Zwierze(string nazwa,string pole)
        {
            _nazwa = nazwa;
            _readonly = pole;
        }

        public string Nazwa
        {
            get 
            {
                return _nazwa;
            }
            set 
            {
                if (!String.IsNullOrEmpty(value))

                _nazwa=value;
                
            }

        }

        public String Nazwa2 
        {
            set
            {
                if (!String.IsNullOrEmpty(value))

                    _nazwa2 = value;
            }
        }

        public String Readonly 
        
        {
            get
            {
                return _readonly;
            }
        }

        public int MyProperty { get; set; }

    }
}
