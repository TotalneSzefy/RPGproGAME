using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    public class Bohater : Postać, INotifyPropertyChanged
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

        public static Bohater Instancja { get; set; }

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
            Ekwipunek.Add(new Zbroja("Bylejaka Zbroja", 1, 0, 0, "ms-appx:///Assets//NPCimages//zbroja.png"));
            Ekwipunek.Add(new Tarcza("Bylejaka Tarcza", 1, 0, 0, "ms-appx:///Assets//NPCimages//tarcza.png"));
            Ekwipunek.Add(new Buty("Bylejakie Buty", 1, 0, 0, "ms-appx:///Assets//NPCimages//buty.png"));
            Ekwipunek.Add(new Spodnie("Bylejakie Spodnie", 1, 0, 0, "ms-appx:///Assets//NPCimages//spodnie.png"));
            Ekwipunek.Add(new Broń("Bylejaki miecz", 1, 0, 0, "ms-appx:///Assets//NPCimages//miecz.png"));

        }

        public static void CreateStaticInstance(string imie, string sciezkaIkony, int poziom, int życie, int siła, int inteligencja, int zrecznosc, int wytrzymalosc)
        {
            Instancja = new Bohater(imie, sciezkaIkony, poziom, życie, siła, inteligencja, zrecznosc, wytrzymalosc);
        }


        #endregion

        #region Metody

        public void ZaluzPrzedmiot(Przedmiot przedmiot)
        {
            if (przedmiot.WymaganyLVL <= Poziom)
            {
                if (przedmiot is Hełm)
                {
                    if (Helm != null)
                        Helm.Zalozony = false;
                    Helm = (Hełm)przedmiot;
                }
                else if (przedmiot is Zbroja)
                {
                    if (Zbroja != null)
                        Zbroja.Zalozony = false;
                    Zbroja = (Zbroja)przedmiot;
                }
                else if (przedmiot is Tarcza)
                {
                    if (Tarcza != null)
                        Tarcza.Zalozony = false;
                    Tarcza = (Tarcza)przedmiot;
                }
                else if (przedmiot is Buty)
                {
                    if (Buty != null)
                        Buty.Zalozony = false;
                    Buty = (Buty)przedmiot;
                }
                else if (przedmiot is Spodnie)
                {
                    if (Spodnie != null)
                        Spodnie.Zalozony = false;
                    Spodnie = (Spodnie)przedmiot;
                }
                else if (przedmiot is Broń)
                {
                    if (Bron != null)
                        Bron.Zalozony = false;
                    Bron = (Broń)przedmiot;
                    Bron.Zalozony = true;
                }
                przedmiot.Zalozony = true;
            }
            
        }

        public void zdejmijPrzedmiot(Przedmiot przedmiot)
        {
            string obraz = "ms-appx:///Assets//przezroczysty.png"; //SEBA TU DAJ ITEM 100% PRZEZROCZYSTY
            if (przedmiot is Hełm)
            {
                if (Helm != null)
                    Helm.Zalozony = false;
                Helm = new Hełm("", 0, 0, 0, obraz);
            }
            else if (przedmiot is Zbroja)
            {
                Zbroja.Zalozony = false;
                Zbroja = new Zbroja("", 0, 0, 0, obraz);
            }
            else if (przedmiot is Tarcza)
            {
                
                    Tarcza.Zalozony = false;
                Tarcza = new Tarcza("", 0, 0, 0, obraz);
            }
            else if (przedmiot is Buty)
            {
                
                    Buty.Zalozony = false;
                Buty = new Buty("", 0, 0, 0, obraz);
            }
            else if (przedmiot is Spodnie)
            {
                Spodnie.Zalozony = false;
                Spodnie = new Spodnie("", 0, 0, 0, obraz);
            }
            else if (przedmiot is Broń)
            {
                Bron.Zalozony = false;
                Bron = new Broń("", 0, 0, 0, obraz);
            }
        }

        #endregion

    }
}
