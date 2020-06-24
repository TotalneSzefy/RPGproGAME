using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane 
{
    public class Postać
    {

        #region Pola
        string imie;
        string sciezkaIkony;
        int poziom;
        public int życie;

        int obrazenia;
        int obrona;
        int szansaUnik;
        int szansaTrafienia;

        
        #endregion
        public string Imie { get => imie; set => imie = value; }
        public string SciezkaIkony { get => sciezkaIkony; set => sciezkaIkony = value; }
        public int Poziom { get => poziom; set => poziom = value; }
        
        


        #region Konstruktory

        public Postać(string imie, string sciezkaIkony, int poziom)
        {
            this.Imie = imie;
            this.SciezkaIkony = sciezkaIkony;
            this.Poziom = poziom;
        }

        public Postać()
        {

        }
        #endregion





    }
}
