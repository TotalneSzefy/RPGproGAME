using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    public enum rodzajPoty { 
    Zycia,
    Sily,
    Trafienia,
    Niesmiertelnosci
    }
    public class Użytkowe : Przedmiot
    {
        public rodzajPoty rodzaj;
        internal int bonusZycie;

        public Użytkowe(string nazwa, int ilosc, int cena, int wymaganyLVL, string sciezkaIkony, rodzajPoty rodzaj) : base(nazwa, ilosc, cena, wymaganyLVL, sciezkaIkony)
        {
            this.rodzaj = rodzaj;
            switch (rodzaj)
            {
                case rodzajPoty.Zycia:
                    bonusZycie = 20;
                    break;
            }
        }
    }
}
