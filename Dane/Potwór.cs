using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    public class Potwór : Postać, INotifyPropertyChanged
	{
		private int obrazenia;
		private int obrona;
		private int szansaUnik;
		private int szansaTrafienia;

		public int zloto;
		public int exp;
		public Przedmiot przedmiot;

        public int Obrazenia { get => obrazenia; set => obrazenia = value; }
        public int Obrona { get => obrona; set => obrona = value; }
        public int SzansaUnik { get => szansaUnik; set => szansaUnik = value; }
        public int SzansaTrafienia { get => szansaTrafienia; set => szansaTrafienia = value; }
		public int Zycie
		{
			get => życie; set
			{
				życie = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Zycie"));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		public Potwór(string imie, string sciezkaIkony, int poziom, int życie) : base(imie, sciezkaIkony, poziom)
		{
			this.Zycie = życie;
		}
		public Potwór()
		{

		}

        
    }
}
