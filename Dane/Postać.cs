using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane 
{
    class Postać : INotifyPropertyChanged
    {
        string imie;
        string sciezkaIkony;
        int poziom;
        int życie;

        int obrażenia;
        int obrona;
        int szansaUnik;
        int szansaTrafienia;

        public event PropertyChangedEventHandler PropertyChanged;

        public string GetImie()
        {
            return imie;
        }

        public void SetImie(string value)
        {
            imie = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Imie"));
        }

        public string GetSciezkaIkony()
        {
            return sciezkaIkony;
        }

        public void SetSciezkaIkony(string value)
        {
            sciezkaIkony = value;
        }

        public int GetPoziom()
        {
            return poziom;
        }

        public void SetPoziom(int value)
        {
            poziom = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Poziom"));
        }

        public int GetŻycie()
        {
            return życie;
        }

        public void SetŻycie(int value)
        {
            życie = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Życie"));
        }

        public int GetObrażenia()
        {
            return obrażenia;
        }

        public void SetObrażenia(int value)
        {
            obrażenia = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Obrażenia"));
        }

        public int GetObrona()
        {
            return obrona;
        }

        public void SetObrona(int value)
        {
            obrona = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Obrona"));
        }

        public int GetSzansaUnik()
        {
            return szansaUnik;
        }

        public void SetSzansaUnik(int value)
        {
            szansaUnik = value;
            PropertyChanged(this, new PropertyChangedEventArgs("SzansaUnik"));
        }

        public int GetSzansaTrafienia()
        {
            return szansaTrafienia;
        }

        public void SetSzansaTrafienia(int value)
        {
            szansaTrafienia = value;
            PropertyChanged(this, new PropertyChangedEventArgs("SzansaTrafienia"));
        }
    }
}
