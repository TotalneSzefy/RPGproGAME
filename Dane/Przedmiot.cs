using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    public class Przedmiot
    {
        private string nazwa;
        private string ilosc;
        private int cena;
        private int wymaganyLVL;
        private string sciezkaIkony;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Ilosc { get => ilosc; set => ilosc = value; }
        public int Cena { get => cena; set => cena = value; }
        public int WymaganyLVL { get => wymaganyLVL; set => wymaganyLVL = value; }
        public string SciezkaIkony { get => sciezkaIkony; set => sciezkaIkony = value; }
    }
}
