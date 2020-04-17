using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane 
{
    class Postać
    {
        #region Pola
        string imie;
        string sciezkaIkony;
        int poziom;
        int życie;

        int obrazenia;
        int obrona;
        int szansaUnik;
        int szansaTrafienia;
        #endregion
        public string Imie { get => imie; set => imie = value; }
        public string SciezkaIkony { get => sciezkaIkony; set => sciezkaIkony = value; }
        public int Poziom { get => poziom; set => poziom = value; }
        public int Życie { get => życie; set => życie = value; }
        public int Obrazenia { get => obrazenia; set => obrazenia = value; }
        public int Obrona { get => obrona; set => obrona = value; }
        public int SzansaUnik { get => szansaUnik; set => szansaUnik = value; }
        public int SzansaTrafienia { get => szansaTrafienia; set => szansaTrafienia = value; }


        #region Konstruktory

        public Postać(string imie, string sciezkaIkony, int poziom, int życie)
        {
            this.Imie = imie;
            this.SciezkaIkony = sciezkaIkony;
            this.Poziom = poziom;
            this.Życie = życie;
        }

        #endregion

        

        

    }
}
