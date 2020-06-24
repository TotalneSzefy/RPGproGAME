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
        private string zalozonySTR;
       

        private double obrazeniaBonus;
        private double obronaBonus;
        private double sTrafieniaBonus;
        private double sUnikBonus;

        private double obrazeniaMoznik;
        private double obronaMoznik;
        private double sTrafieniaMozniks;
        private double sUnikMoznik;

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
                if (zalozony)
                {
                    ZalozonySTR = "Założony";
                }
                else
                {
                    ZalozonySTR = "";
                }
                PropertyChanged(this, new PropertyChangedEventArgs("Zalozony"));
            }
        }

        public string ZalozonySTR
        {
            get => zalozonySTR; set
            {
                zalozonySTR = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ZalozonySTR"));
            }
        }

        public double ObrazeniaBonus { get => obrazeniaBonus; set => obrazeniaBonus = value; }
        public double ObronaBonus { get => obronaBonus; set => obronaBonus = value; }
        public double STrafieniaBonus { get => sTrafieniaBonus; set => sTrafieniaBonus = value; }
        public double SUnikBonus { get => sUnikBonus; set => sUnikBonus = value; }
        public double ObrazeniaMnoznik { get => obrazeniaMoznik; set => obrazeniaMoznik = value; }
        public double ObronaMnoznik { get => obronaMoznik; set => obronaMoznik = value; }
        public double STrafieniaMnozniks { get => sTrafieniaMozniks; set => sTrafieniaMozniks = value; }
        public double SUnikMnoznik { get => sUnikMoznik; set => sUnikMoznik = value; }

        public Przedmiot(string nazwa, int ilosc, int cena, int wymaganyLVL, string sciezkaIkony)
        {
            Nazwa = nazwa;
            Ilosc = ilosc;
            Cena = cena;
            WymaganyLVL = wymaganyLVL;
            SciezkaIkony = sciezkaIkony;
            Zalozony = false;

            ObrazeniaBonus = 5;
            ObronaBonus = 5;
            STrafieniaBonus = 5;
            SUnikBonus = 5;
            ObrazeniaMnoznik = 0;
            ObronaMnoznik = 0;
            STrafieniaMnozniks = 0;
            SUnikMnoznik = 0;
        }

        public Przedmiot()
        {

        }

        public void ZerujStaty()
        {
            ObrazeniaBonus = 0;
            ObronaBonus = 0;
            STrafieniaBonus = 0;
            SUnikBonus = 0;
            ObrazeniaMnoznik = 0;
            ObronaMnoznik = 0;
            STrafieniaMnozniks = 0;
            SUnikMnoznik = 0;
        }

    }
}
