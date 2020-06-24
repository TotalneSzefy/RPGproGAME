using RPG.Dane;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Katakumby : Page
    {

        public ObservableCollection<Przedmiot> sklepPoty = new ObservableCollection<Przedmiot>();
        public ObservableCollection<Przedmiot> posiadanePoty = new ObservableCollection<Przedmiot>();

        public Katakumby()
        {
            sklepPoty.Add(new Użytkowe("Mikstura Życia", 1, 500, 1, "ms-appx:///Assets//Potki//potka1.png", rodzajPoty.Zycia));
            sklepPoty.Add(new Użytkowe("Mikstura Nieśmiertelności", 1, 500, 1, "ms-appx:///Assets//Potki//potka2.png", rodzajPoty.Niesmiertelnosci));
            sklepPoty.Add(new Użytkowe("Mikstura Siły", 1, 500, 1, "ms-appx:///Assets//Potki//potka3.png", rodzajPoty.Sily));
            sklepPoty.Add(new Użytkowe("Mikstura Trafienia", 1, 500, 1, "ms-appx:///Assets//Potki//potka4.png", rodzajPoty.Trafienia));

            this.InitializeComponent();

            sklepPotekListBox.ItemsSource = sklepPoty;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void walcz_BTN_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Walka), posiadanePoty);
        }

        private void kup_BTN_Click(object sender, RoutedEventArgs e)
        {
            Użytkowe potka = (Użytkowe)sklepPotekListBox.SelectedItem;
            if (potka != null)
            {
                if (Bohater.Instancja.Zloto >= potka.Cena)
                {
                    Bohater.Instancja.Zloto -= potka.Cena;
                    posiadanePoty.Add(potka);
                }
            }
        }
    }
}
