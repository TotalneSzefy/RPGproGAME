using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    class Bohater : Postać, INotifyPropertyChanged
    {
        #region Pola
        private int doswiadczenie;
        private int zloto;
        private int sila;
        private int inteligencja;
        private int zrecznosc;
        private int wytrzymalosc;

        private Hełm helm;
        private Broń bron;
        private Tarcza tarcza;
        private Spodnie spodnie;
        private Zbroja zbroja;
        private Buty buty;

        #endregion

        public ObservableCollection<Przedmiot> Ekwipunek = new ObservableCollection<Przedmiot>();
        public event PropertyChangedEventHandler PropertyChanged = delegate { };



        #region Właściwości
        public int Złoto { get => zloto; set => zloto = value; }
        public int Sila
        {
            get => sila;
            set
            {
                sila = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Sila"));
            }
        }
        public int Inteligencja
        {
            get => inteligencja;
            set
            {
                inteligencja = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Inteligencja"));
            }
        }
        public int Zrecznosc
        {
            get => zrecznosc;
            set
            {
                zrecznosc = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Zrecznosc"));
            }
        }
        public int Wytrzymalosc
        {
            get => wytrzymalosc;
            set
            {
                wytrzymalosc = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Wytrzymalosc"));
            }
        }
        public int Doświadczenie { get => doswiadczenie; set => doswiadczenie = value; }
        internal Hełm Helm
        {
            get => helm;
            set
            {
                helm = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Helm"));
            }
        }
        public Broń Bron
        {
            get => bron;
            set
            {
                bron = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Bron"));
            }
        }
        public Tarcza Tarcza
        {
            get => tarcza;
            set
            {
                tarcza = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Tarcza"));
            }
        }
        public Spodnie Spodnie
        {
            get => spodnie;
            set
            {
                spodnie = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Spodnie"));
            }
        }
        public Zbroja Zbroja
        {
            get => zbroja;
            set
            {
                zbroja = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Zbroja"));
            }
        }
        public Buty Buty
        {
            get => buty;
            set
            {
                buty = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Buty"));
            }
        }
        #endregion

        #region Kostruktory
        public Bohater(string imie, string sciezkaIkony, int poziom, int życie, int siła, int inteligencja, int zrecznosc, int wytrzymalosc) : base(imie, sciezkaIkony, poziom, życie)
        {
            this.Sila = siła;
            this.Inteligencja = inteligencja;
            this.Zrecznosc = zrecznosc;
            this.Wytrzymalosc = wytrzymalosc;
            //string nazwa,int ilosc, int cena, int wymaganyLVL, string sciezkaIkony
            Ekwipunek.Add(new Hełm("Bylejaka Czapka", 1, 0, 0, "ms-appx:///Assets//NPCimages//helm.png"));
            //Helm = new Hełm("Bylejaka Czapka", 1, 0, 0, "ms-appx:///Assets//NPCimages//helm.png");
        }

        #endregion
    }
}
