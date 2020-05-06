using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    public class Przedmiot : INotifyPropertyChanged
    {
        private string nazwa;
        private int ilosc;
        private int cena;
        private int wymaganyLVL;
        private string sciezkaIkony;
        private bool zalozony;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };



        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int Ilosc { get => ilosc; set => ilosc = value; }
        public int Cena { get => cena; set => cena = value; }
        public int WymaganyLVL { get => wymaganyLVL; set => wymaganyLVL = value; }
        public string SciezkaIkony { get => sciezkaIkony; set => sciezkaIkony = value; }
        public bool Zalozony
        {
            get => zalozony;
            set
            {
                zalozony = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Zalozony"));
            }
        }

        public Przedmiot(string nazwa, int ilosc, int cena, int wymaganyLVL, string sciezkaIkony)
        {
            Nazwa = nazwa;
            Ilosc = ilosc;
            Cena = cena;
            WymaganyLVL = wymaganyLVL;
            SciezkaIkony = sciezkaIkony;
            Zalozony = false;
        }
        public Przedmiot()
        {

        }

    }
}
