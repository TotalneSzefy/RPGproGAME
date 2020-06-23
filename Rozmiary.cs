using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    class Rozmiary: INotifyPropertyChanged
    {
        private int statyFontSize1;
        private int przyciskiFontSize1;
        private string tlo;


        public Rozmiary()
        {
            StatyFontSize1 = 10;
            PrzyciskiFontSize1 = 10;
        }
        public string Tlo
        {
            get => tlo;

            set
            {
                tlo = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Tlo"));
            }

        }

        public int StatyFontSize1
        {
            get => statyFontSize1;

            set
            {
                statyFontSize1 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("StatyFontSize1"));
            }

        }
        public int PrzyciskiFontSize1
        {
            get => przyciskiFontSize1;

            set
            {
                przyciskiFontSize1 = value;
                PropertyChanged(this, new PropertyChangedEventArgs("PrzyciskiFontSize1"));
            }

        }


        public event PropertyChangedEventHandler PropertyChanged = delegate { };

    }
}
