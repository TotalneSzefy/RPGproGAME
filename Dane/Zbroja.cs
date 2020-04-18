using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    class Zbroja : Przedmiot
    {
        public Zbroja(string nazwa, int ilosc, int cena, int wymaganyLVL, string sciezkaIkony) : base(nazwa, ilosc, cena, wymaganyLVL, sciezkaIkony)
        {

        }
    }
}
