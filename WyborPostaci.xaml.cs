using RPG.Dane;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class WyborPostaci : Page
    {
        public WyborPostaci()
        {
            this.InitializeComponent();
        }

        
        //komentarz dla zmiany xD


        private void wroc_button_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }

        }

        private void wybierz_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rozgrywka));
        }



        //dorba w kazdej postaci trzeba tutaj zapisywać ją do pliku tekstowego, np o nazwie takiej jak nazywać się bedzie postać, zapisuejmy staty w tym momencie i plik bedzie np: nickStaty
        //w rozgrywce zrobimy plik tekstowy  nickEkwipunek i wtedy wszystko bedzie proste do zrobienia a nawet w przyszłosci bedzie sie dalo saveovac wiecej postaci xD
        #region Wybor postaci click
        private void Karzel_Clik(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(NazwaPostaci_TB.Text))
            {
                string imie = NazwaPostaci_TB.Text;
                Bohater klasa = new Bohater(imie, "ms-appx:///Assets///Postacie/Karzel1.png", 1, 100, 12, 0, 3, 5);
                otworzScanaRozgrywka(klasa);
            }
            
        }

        private async void Wojownik_Clik(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(NazwaPostaci_TB.Text))
            {
                string imie = NazwaPostaci_TB.Text;
                Bohater klasa = new Bohater(imie, "ms-appx:///Assets///Postacie/wojownik.png", 1, 100, 7, 4, 4, 5);
                otworzScanaRozgrywka(klasa);

                //wlasciwie taka linijka w każdym etapie gry służyłaby do zapisania postaci
                string zapis = imie + ",ms-appx:///Assets///Postacie/wojownik.png" + ",1,100,7,4,4,5";

                //BETA ZAPISYWANIE STATOW
                var local = ApplicationData.Current.LocalFolder;
                
                StorageFile file = await local.CreateFileAsync(imie + "Staty");
                await FileIO.WriteTextAsync(file, zapis);
            }
        }

        private void Zwiadowca_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(NazwaPostaci_TB.Text))
            {
                string imie = NazwaPostaci_TB.Text;
                Bohater klasa = new Bohater(imie, "ms-appx:///Assets///Postacie/Zwiadowca.png", 1, 100, 5, 5, 5, 5);
                otworzScanaRozgrywka(klasa);
            }
        }
        #endregion
        void otworzScanaRozgrywka(Bohater klasa)
        {
            this.Frame.Navigate(typeof(Rozgrywka),klasa);
        }

        Rozmiary rozmiary = new Rozmiary();

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if ((((Frame)Window.Current.Content).ActualWidth <= 501) || (((Frame)Window.Current.Content).ActualHeight <= 501))
            {
                rozmiary.StatyFontSize1 = 7;
                wroc_button.FontSize = 7;
                rozmiary.PrzyciskiFontSize1 = 25;
                NazwaPostaci_TB.FontSize = 9;
            }
            else if ((((Frame)Window.Current.Content).ActualWidth <= 800) || (((Frame)Window.Current.Content).ActualHeight <= 600))
            {
                rozmiary.StatyFontSize1 = 20;
                wroc_button.FontSize = 20;
                rozmiary.PrzyciskiFontSize1 = 50;
                NazwaPostaci_TB.FontSize = 20;
            }
            else if ((((Frame)Window.Current.Content).ActualWidth <= 1370) || (((Frame)Window.Current.Content).ActualHeight <= 770))
            {
                rozmiary.StatyFontSize1 = 27;
                wroc_button.FontSize = 27;
                rozmiary.PrzyciskiFontSize1 = 75;
                NazwaPostaci_TB.FontSize = 50;
            }
            else if ((((Frame)Window.Current.Content).ActualWidth < 1920) || (((Frame)Window.Current.Content).ActualHeight < 1080))
            {
                rozmiary.StatyFontSize1 = 40;
                wroc_button.FontSize = 40;
                rozmiary.PrzyciskiFontSize1 = 100;
                NazwaPostaci_TB.FontSize = 80;
            }
         
        }
    }
}
