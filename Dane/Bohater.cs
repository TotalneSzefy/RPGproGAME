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

		private int obrazenia;
		private int obrona;
		private int szansaUnik;
		private int szansaTrafienia;

		private Hełm helm;
		private Broń bron;
		private Tarcza tarcza;
		private Spodnie spodnie;
		private Zbroja zbroja;
		private Buty buty;

		#endregion

		public ObservableCollection<Przedmiot> Ekwipunek = new ObservableCollection<Przedmiot>();

		public event PropertyChangedEventHandler PropertyChanged = delegate { };
		protected void RaisePropertyChanged(string name)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public static Bohater Instancja { get; set; }

		#region Właściwości
		public int Zloto
		{
			get => zloto; set
			{
				zloto = value;
				RaisePropertyChanged("Zloto");


			}
		}
		public int Sila
		{
			get => sila;
			set
			{
				sila = value;
				aktualizujInfo();
				PropertyChanged(this, new PropertyChangedEventArgs("Sila"));
			}
		}
		public int Inteligencja
		{
			get => inteligencja;
			set
			{
				inteligencja = value;
				aktualizujInfo();
				PropertyChanged(this, new PropertyChangedEventArgs("Inteligencja"));
			}
		}
		public int Zrecznosc
		{
			get => zrecznosc;
			set
			{
				zrecznosc = value;
				aktualizujInfo();
				PropertyChanged(this, new PropertyChangedEventArgs("Zrecznosc"));
			}
		}
		public int Wytrzymalosc
		{
			get => wytrzymalosc;
			set
			{
				wytrzymalosc = value;
				aktualizujInfo();
				PropertyChanged(this, new PropertyChangedEventArgs("Wytrzymalosc"));
			}
		}

		public int Obrazenia
		{
			get
			{
				return obrazenia;
			}

			set
			{
				obrazenia = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Obrazenia"));
			}
		}
		public int Obrona
        {
            get
            {
                return obrona;
			}

            set
            {
                obrona = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Obrona"));
            }
        }
        public int SzansaUnik
        {
            get
            {
                return szansaUnik;
			}

            set
            {
                szansaUnik = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SzansaUnik"));
            }
        }
        public int SzansaTrafienia
        {
            get
            {
                return szansaTrafienia;
			}

            set
            {
                szansaTrafienia = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SzansaTrafienia"));
            }
        }
        public int Doświadczenie
        {
            get
            {
                return doswiadczenie;
            }

            set
            {
                doswiadczenie = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Doświadczenie"));
            }
        }


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
			this.zloto = 500000;
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
			aktualizujInfo();
		}

		public void zdejmijPrzedmiot(Przedmiot przedmiot)
		{
			string obraz = "ms-appx:///Assets//przezroczysty.png"; //SEBA TU DAJ ITEM 100% PRZEZROCZYSTY
			if (przedmiot is Hełm)
			{
				if (Helm != null)
					Helm.Zalozony = false;
				Helm = new Hełm("", 0, 0, 0, obraz);
				Helm.ZerujStaty();
			}
			else if (przedmiot is Zbroja)
			{
				Zbroja.Zalozony = false;
				Zbroja = new Zbroja("", 0, 0, 0, obraz);
				Zbroja.ZerujStaty();
			}
			else if (przedmiot is Tarcza)
			{
				
					Tarcza.Zalozony = false;
				Tarcza = new Tarcza("", 0, 0, 0, obraz);
				Tarcza.ZerujStaty();
			}
			else if (przedmiot is Buty)
			{
				
					Buty.Zalozony = false;
				Buty = new Buty("", 0, 0, 0, obraz);
				Buty.ZerujStaty();
			}
			else if (przedmiot is Spodnie)
			{
				Spodnie.Zalozony = false;
				Spodnie = new Spodnie("", 0, 0, 0, obraz);
				Spodnie.ZerujStaty();
			}
			else if (przedmiot is Broń)
			{
				Bron.Zalozony = false;
				Bron = new Broń("", 0, 0, 0, obraz);
				Bron.ZerujStaty();
			}
			aktualizujInfo();
		}

		public void obliczObrazenia()
		{
			double bazowa = Sila;
			double mnoznik = 1;
			if (Helm != null)
			{
				bazowa += Helm.ObrazeniaBonus;
				mnoznik += Helm.ObrazeniaMnoznik;
			}
			if (Zbroja != null)
			{
				bazowa += Zbroja.ObrazeniaBonus;
				mnoznik += Zbroja.ObrazeniaMnoznik;
			}
			if (Tarcza != null)
			{
				bazowa += Tarcza.ObrazeniaBonus;
				mnoznik += Tarcza.ObrazeniaMnoznik;
			}
			if (Buty != null)
			{
				bazowa += Buty.ObrazeniaBonus;
				mnoznik += Buty.ObrazeniaMnoznik;
			}
			if (Spodnie != null)
			{
				bazowa += Spodnie.ObrazeniaBonus;
				mnoznik += Spodnie.ObrazeniaMnoznik;
			}
			if (Bron != null)
			{
				bazowa += Bron.ObrazeniaBonus;
				mnoznik += Bron.ObrazeniaMnoznik;
			}

			double result = bazowa * mnoznik;
			Obrazenia = (int)result;
		}

		public void obliczObrona()
		{
			
			double bazowa = Wytrzymalosc;
			double mnoznik = 1;
			if (Helm != null)
			{
				bazowa += Helm.ObronaBonus;
				mnoznik += Helm.ObronaMnoznik;
			}
			if (Zbroja != null)
			{
				bazowa += Zbroja.ObronaBonus;
				mnoznik += Zbroja.ObronaMnoznik;
			}
			if (Tarcza != null)
			{
				bazowa += Tarcza.ObronaBonus;
				mnoznik += Tarcza.ObronaMnoznik;
			}
			if (Buty != null)
			{
				bazowa += Buty.ObronaBonus;
				mnoznik += Buty.ObronaMnoznik;
			}
			if (Spodnie != null)
			{
				bazowa += Spodnie.ObronaBonus;
				mnoznik += Spodnie.ObronaMnoznik;
			}
			if (Bron != null)
			{
				bazowa += Bron.ObronaBonus;
				mnoznik += Bron.ObrazeniaMnoznik;
			}


			double result = bazowa * mnoznik;
			Obrona = (int)result;
		}

		public void obliczSTrafienia()
		{
			double bazowa = Zrecznosc + 0.75 * Inteligencja;
			double mnoznik = 1;
			if (Helm != null)
			{
				bazowa += Helm.STrafieniaBonus;
				mnoznik += Helm.STrafieniaMnozniks;
			}
			if (Zbroja != null)
			{
				bazowa += Zbroja.STrafieniaBonus;
				mnoznik += Zbroja.STrafieniaMnozniks;
			}
			if (Tarcza != null)
			{
				bazowa += Tarcza.STrafieniaBonus;
				mnoznik += Tarcza.STrafieniaMnozniks;
			}
			if (Buty != null)
			{
				bazowa += Buty.STrafieniaBonus;
				mnoznik += Buty.STrafieniaMnozniks;
			}
			if (Spodnie != null)
			{
				bazowa += Spodnie.STrafieniaBonus;
				mnoznik += Spodnie.STrafieniaMnozniks;
			}
			if (Bron != null)
			{
				bazowa += Bron.STrafieniaBonus;
				mnoznik += Bron.STrafieniaMnozniks;
			}


			double result = bazowa * mnoznik;
			SzansaTrafienia = (int)result;
		}

		public void obliczSUnik()
		{
			double bazowa = Zrecznosc;
			double mnoznik = 1;
			if (Helm != null)
			{
				bazowa += Helm.SUnikBonus;
				mnoznik += Helm.SUnikMnoznik;
			}
			if (Zbroja != null)
			{
				bazowa += Zbroja.SUnikBonus;
				mnoznik += Zbroja.SUnikMnoznik;
			}
			if (Tarcza != null)
			{
				bazowa += Tarcza.SUnikBonus;
				mnoznik += Tarcza.SUnikMnoznik;
			}
			if (Buty != null)
			{
				bazowa += Buty.SUnikBonus;
				mnoznik += Buty.SUnikMnoznik;
			}
			if (Spodnie != null)
			{
				bazowa += Spodnie.SUnikBonus;
				mnoznik += Spodnie.SUnikMnoznik;
			}
			if (Bron != null)
			{
				bazowa += Bron.SUnikBonus;
				mnoznik += Bron.SUnikMnoznik;
			}


			double result = bazowa * mnoznik;
			SzansaUnik = (int)result;
		}

		private void aktualizujInfo()
		{
			obliczObrazenia();
			obliczObrona();
			obliczSTrafienia();
			obliczSUnik();
		}

		#endregion

	}
}
