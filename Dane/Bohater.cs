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
        
        private int doświadczenie;
        private int złoto;
        private int siła;
        private int inteligencja;
        private int zrecznosc;
        private int wytrzymalosc;

        private Hełm hełm;
        private Broń broń;
        private Tarcza tarcza;
        private Spodnie spodnie;
        private Zbroja zbroja;
        private Buty buty;

        ObservableCollection<Przedmiot> Ekwipunek = new ObservableCollection<Przedmiot>();

        public new event PropertyChangedEventHandler PropertyChanged;
        public int GetDoświadczenie()
        {
            return doświadczenie;
        }

        public void SetDoświadczenie(int value)
        {
            doświadczenie = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Doświadczenie"));

        }

        public int GetZłoto()
        {
            return złoto;
        }

        public void SetZłoto(int value)
        {
            złoto = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Złoto"));
        }

        public int GetSiła()
        {
            return siła;
        }

        public void SetSiła(int value)
        {
            siła = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Siła"));
        }

        public int GetInteligencja()
        {
            return inteligencja;
        }

        public void SetInteligencja(int value)
        {
            inteligencja = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Inteligencja"));
        }

        public int GetZrecznosc()
        {
            return zrecznosc;
        }

        public void SetZrecznosc(int value)
        {
            zrecznosc = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Zrecznosc"));
        }

        public int GetWytrzymalosc()
        {
            return wytrzymalosc;
        }

        public void SetWytrzymalosc(int value)
        {
            wytrzymalosc = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Wytrzymalosc"));
        }

        internal Hełm GetHełm()
        {
            return hełm;
        }

        internal void SetHełm(Hełm value)
        {
            hełm = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Hełm"));
        }

        internal Broń GetBroń()
        {
            return broń;
        }

        internal void SetBroń(Broń value)
        {
            broń = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Broń"));
        }

        internal Tarcza GetTarcza()
        {
            return tarcza;
        }

        internal void SetTarcza(Tarcza value)
        {
            tarcza = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Tarcza"));
        }

        internal Spodnie GetSpodnie()
        {
            return spodnie;
        }

        internal void SetSpodnie(Spodnie value)
        {
            spodnie = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Spodnie"));
        }

        internal Zbroja GetZbroja()
        {
            return zbroja;
        }

        internal void SetZbroja(Zbroja value)
        {
            zbroja = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Zbroja"));
        }

        internal Buty GetButy()
        {
            return buty;
        }

        internal void SetButy(Buty value)
        {
            buty = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Buty"));
        }
    }
}
