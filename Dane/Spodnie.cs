﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dane
{
    public class Spodnie : Przedmiot
    {
        public Spodnie()
        {
        }

        public Spodnie(string nazwa, int ilosc, int cena, int wymaganyLVL, string sciezkaIkony) : base(nazwa, ilosc, cena, wymaganyLVL, sciezkaIkony)
        {

        }
    }
}
