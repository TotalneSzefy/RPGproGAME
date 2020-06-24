using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    public class Broń : Przedmiot
    {
        

        public Broń(string nazwa, int ilosc, int cena, int wymaganyLVL, string sciezkaIkony) : base(nazwa, ilosc, cena, wymaganyLVL, sciezkaIkony)
        {
            
        }

        public Broń(string nazwa, int ilosc, int cena, int wymaganyLVL, string sciezkaIkony, double ObrazeniaBonus, double ObronaBonus, double STrafieniaBonus, double SUnikBonus, double ObrazeniaMnoznik, double ObronaMnoznik, double STrafieniaMnozniks, double SUnikMnoznik) : base(nazwa, ilosc, cena, wymaganyLVL, sciezkaIkony)
        {
            this.ObrazeniaBonus = ObrazeniaBonus;
            this.ObronaBonus = ObronaBonus;
            this.STrafieniaBonus = STrafieniaBonus;
            this.SUnikBonus = SUnikBonus;
            this.ObrazeniaMnoznik = ObrazeniaMnoznik;
            this.ObronaMnoznik = ObronaMnoznik;
            this.STrafieniaMnozniks = STrafieniaMnozniks;
            this.SUnikMnoznik = SUnikMnoznik;
        }

        public Broń()
        { 
        
        }

        

    }
}
