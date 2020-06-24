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
        Użytkowe niesmiertelnosc;
        Użytkowe trafienia;
        Użytkowe sily;

        Random rand = new Random();

        public Użytkowe PotkaNiesmiertelnosci { get => niesmiertelnosc; set => niesmiertelnosc = value; }
        public Użytkowe PotkaTrafienia { get => trafienia; set => trafienia = value; }
        public Użytkowe PotkaSily { get => sily; set => sily = value; }

        public void Atakuj(Potwór potwor)
        {
            int trafienie = Celujesz();
            int unik = potwor.SzansaUnik;
            if (trafienie >= unik)
            {
                if (Bohater.Instancja.Obrazenia - potwor.Obrona > 0)
                {
                    ZadjeszObrazenia(potwor);
                }
            }

        }

        private int Celujesz()
        {
            if (PotkaTrafienia != null)
            {
                return int.MaxValue;
            }
            else
            {
                return rand.Next(0, 100) + Bohater.Instancja.SzansaTrafienia;
            }
        }

        private void ZadjeszObrazenia(Potwór potwor)
        {
            if (PotkaSily != null)
            {
                potwor.Zycie -= Bohater.Instancja.Obrazenia * 2 - potwor.Obrona;
            }
            else
            {
                potwor.Zycie -= Bohater.Instancja.Obrazenia - potwor.Obrona;
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
                    OtrzymujeszObrazenia(potwor);
                }
            }
        }

        private void OtrzymujeszObrazenia(Potwór potwor)
        {
            if (PotkaNiesmiertelnosci != null)
            {
                PotkaNiesmiertelnosci = null;
            }
            else
            {
                Bohater.Instancja.Zycie -= potwor.Obrazenia - Bohater.Instancja.Wytrzymalosc;
            }
        }

    }

}
