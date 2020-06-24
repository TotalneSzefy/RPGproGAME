using RPG.Dane;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Logika
{
    public class WalkaClass
    {
        Random rand = new Random();
        public void Atakuj(Potwór potwor)
        {
            int trafienie = rand.Next(0, 100) + Bohater.Instancja.SzansaTrafienia;
            int unik = potwor.SzansaUnik;
            if (trafienie >= unik)
            {
                if (Bohater.Instancja.Obrazenia - potwor.Obrona > 0)
                {
                    potwor.Zycie -= Bohater.Instancja.Obrazenia - potwor.Obrona;
                }
            }

        }

        public void Bron_sie(Potwór potwor)
        {
            int trafienie = rand.Next(0, 100) + potwor.SzansaTrafienia;
            int unik = Bohater.Instancja.SzansaUnik;
            if (trafienie >= unik)
            {
                if (potwor.Obrazenia - Bohater.Instancja.Obrona > 0)
                {
                    Bohater.Instancja.Zycie -= potwor.Obrazenia - Bohater.Instancja.Wytrzymalosc;
                }
            }
        }


    }

}
