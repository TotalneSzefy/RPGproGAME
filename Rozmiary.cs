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

        public Rozmiary()
        {
            StatyFontSize1 = 10;
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

        

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

    }
}
