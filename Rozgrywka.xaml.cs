using RPG.Dane;
using System;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RPG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Rozgrywka : Page
    {
        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
        public Rozgrywka()
        {
            this.InitializeComponent();
        }
        

        private async void NavigationPanel_Wyjdz_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string imie = Bohater.Instancja.Imie;
            string sciezkaIkony = Bohater.Instancja.SciezkaIkony;
            int poziom = Bohater.Instancja.Poziom;
            int zycie = Bohater.Instancja.Zycie;
            int siła = Bohater.Instancja.Sila;
            int inteligencja = Bohater.Instancja.Inteligencja;
            int zrecznosc = Bohater.Instancja.Zrecznosc;
            int wytrzymalosc = Bohater.Instancja.Wytrzymalosc;
            int zloto = Bohater.Instancja.Zloto;
            string save = imie + "," + sciezkaIkony + "," + poziom + "," + zycie + "," + siła + "," + inteligencja + "," + zrecznosc + "," + wytrzymalosc + "," + zloto;
            
            


            try //próbuję zapisać nowy
            {
                var local = ApplicationData.Current.LocalFolder;
                StorageFile file = await local.CreateFileAsync(imie + "Staty");
                StorageFile file2 = await local.CreateFileAsync(imie + "Ekwipunek");
                await FileIO.WriteTextAsync(file, save);

                foreach (Przedmiot item in Bohater.Instancja.Ekwipunek)
                {
                    await FileIO.AppendTextAsync(file2, item.ToString());
                }
            }
            catch //jak istnieje to sobie nadpisuje
            {
                var local = ApplicationData.Current.LocalFolder;
                StorageFile file = await local.GetFileAsync(imie + "Staty");
                StorageFile file2 = await local.GetFileAsync(imie + "Ekwipunek");
                await file.DeleteAsync();
                await file2.DeleteAsync();
                StorageFile newFile = await local.CreateFileAsync(imie + "Staty");
                StorageFile newFile2 = await local.CreateFileAsync(imie + "Ekwipunek");
                await FileIO.WriteTextAsync(newFile, save);

                foreach (Przedmiot item in Bohater.Instancja.Ekwipunek)
                {
                    string przedmiot = item.Nazwa +","+ item.Cena + item.SciezkaIkony + "\n";
                    await FileIO.AppendTextAsync(newFile2, przedmiot);
                }
            }
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Karczma_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Karczma));
        }

        private void zwiekszSila_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (Bohater.Instancja.Zloto >= 100 * Bohater.Instancja.Sila)
            {
                Bohater.Instancja.Sila++;
                Bohater.Instancja.Zloto -= 100 * Bohater.Instancja.Sila;
            }
            
        }

        private void zwiekszInt_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (Bohater.Instancja.Zloto >= 100 * Bohater.Instancja.Inteligencja)
            {
                Bohater.Instancja.Inteligencja++;
                Bohater.Instancja.Zloto -= 100 * Bohater.Instancja.Inteligencja;
            }
        }

        private void dodajZrecznosc_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (Bohater.Instancja.Zloto >= 100 * Bohater.Instancja.Zrecznosc)
            {
                Bohater.Instancja.Zrecznosc++;
                Bohater.Instancja.Zloto -= 100 * Bohater.Instancja.Zrecznosc;
            }
        }

        private void dodajWytrzymalosc_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            if (Bohater.Instancja.Zloto >= 100 * Bohater.Instancja.Wytrzymalosc)
            {
                Bohater.Instancja.Wytrzymalosc++;
                Bohater.Instancja.Zloto -= 100 * Bohater.Instancja.Wytrzymalosc;
            }
        }

        private void Ekwipunek_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Przedmiot item = (Przedmiot)Ekwipunek_ListBox.SelectedItem;
            if(item.Zalozony == false)
                Bohater.Instancja.ZaluzPrzedmiot(item);
            else
                Bohater.Instancja.zdejmijPrzedmiot(item);
        }


        Rozmiary rozmiary = new Rozmiary();
        private void Page_SizeChanged(object sender, Windows.UI.Xaml.SizeChangedEventArgs e)
        {
            if ((((Frame)Window.Current.Content).ActualWidth <= 501) || (((Frame)Window.Current.Content).ActualHeight <= 481))
            {
                rozmiary.StatyFontSize1 = 7;
                rozmiary.PrzyciskiFontSize1 = 12;

            }
            else if ((((Frame)Window.Current.Content).ActualWidth <= 800) || (((Frame)Window.Current.Content).ActualHeight <= 680))
            {
                rozmiary.StatyFontSize1 = 17;
                rozmiary.PrzyciskiFontSize1 = 22;

            }
            else if ((((Frame)Window.Current.Content).ActualWidth <= 1370) || (((Frame)Window.Current.Content).ActualHeight <= 880))
            {
                rozmiary.StatyFontSize1 = 25;
                rozmiary.PrzyciskiFontSize1 = 30;

            }
            else if ((((Frame)Window.Current.Content).ActualWidth < 1920) || (((Frame)Window.Current.Content).ActualHeight < 1080))
            {
                rozmiary.StatyFontSize1 = 37;
                rozmiary.PrzyciskiFontSize1 = 40;

            }
        }
        private void Katakumby_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Katakumby));
        }

        private void sell_BTN_Click(object sender, RoutedEventArgs e)
        {
            int wybrany = Ekwipunek_ListBox.SelectedIndex;
            Przedmiot doSprzedarzy = (Przedmiot)Ekwipunek_ListBox.SelectedItem;
            Bohater.Instancja.Zloto += doSprzedarzy.Cena;
            Bohater.Instancja.Ekwipunek.Remove(doSprzedarzy);
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
