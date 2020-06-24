using RPG.Dane;
using RPG.Logika;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RPG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Walka : Page
    {
        Rozmiary ustawienia = new Rozmiary();
        Random rand = new Random();

        Potwór potwor;
        
        
        public Walka()
        {
            potwor = new Potwór("Murlok", "ms-appx:///Assets//Potwory//murlok.png", 1, 100);
            znajdzPotwora();
            this.InitializeComponent();
            int losowe = rand.Next(1, 5);
            ustawienia.Tlo = "Assets//"+losowe+".png";
            Bohater.Instancja.Zycie = 100;
            ustawienia.NumerRundy = 1;
            
        }

        private void znajdzPotwora()
        {
            
            potwor.Obrazenia = rand.Next(0,50);
            potwor.Obrona = rand.Next(0, 50);
            potwor.SzansaTrafienia = rand.Next(0, 50);
            potwor.SzansaUnik = rand.Next(0, 50);
            potwor.Zycie = 100;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void atak_BTN_Click(object sender, RoutedEventArgs e)//Zadaj Cios
         {
            WalkaClass walkaClass = new WalkaClass();
            walkaClass.Atakuj(potwor);
            if (potwor.Zycie > 0)
                walkaClass.Bron_sie(potwor);
            else
            {
                wygralesWalke();
            }
            if (Bohater.Instancja.Zycie <= 0)
            {
                przegralesWalke();
            }
        }

        private async void przegralesWalke()
        {
            var messageDialog = new MessageDialog("Jesteś Żałosny. Przegrałeś");
            await messageDialog.ShowAsync();
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void wygralesWalke()
        {
            Bohater.Instancja.Doświadczenie += potwor.exp;
            Bohater.Instancja.Zloto += potwor.zloto;
            if (potwor.przedmiot != null)
            {
                Bohater.Instancja.Ekwipunek.Add(potwor.przedmiot);

            }
            znajdzPotwora();
            ustawienia.NumerRundy++;
        }
    }

}
