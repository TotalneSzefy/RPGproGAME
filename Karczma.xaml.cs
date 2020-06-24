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
    public sealed partial class Karczma : Page
    {

        public ObservableCollection<Przedmiot> sklepMiecze = new ObservableCollection<Przedmiot>();
        public ObservableCollection<Przedmiot> sklepHelmy = new ObservableCollection<Przedmiot>();
        public ObservableCollection<Przedmiot> sklepZbroje = new ObservableCollection<Przedmiot>();
        public ObservableCollection<Przedmiot> sklepSpodnie = new ObservableCollection<Przedmiot>();
        public ObservableCollection<Przedmiot> sklepButy = new ObservableCollection<Przedmiot>();
        public ObservableCollection<Przedmiot> sklepTarcze = new ObservableCollection<Przedmiot>();

        public Karczma()
        {
            this.InitializeComponent();

            #region Miecze
            sklepMiecze.Add(new Broń("Antyczny miecz", 1, 500, 1, "ms-appx:///Assets//Miecze//antyczny.png"));
            sklepMiecze.Add(new Broń("Miecz barbarzyńcy", 1, 1500, 5, "ms-appx:///Assets//Miecze//barbarzyncy.png"));
            sklepMiecze.Add(new Broń("Długi miecz", 1, 2500, 10, "ms-appx:///Assets//Miecze//dlugiMiecz.png"));
            sklepMiecze.Add(new Broń("Katana", 1, 3500, 15, "ms-appx:///Assets//Miecze//katana.png"));
            sklepMiecze.Add(new Broń("Szabla", 1, 4500, 20, "ms-appx:///Assets//Miecze//szabla.png"));
            #endregion
            
            #region Tarcze
            sklepTarcze.Add(new Tarcza("Drewniana tarcza", 1, 300, 1, "ms-appx:///Assets//Tarcze//drewnianaTarcza.png"));
            sklepTarcze.Add(new Tarcza("Tarcza nowicjusza", 1, 1100, 6, "ms-appx:///Assets//Tarcze//tarczaNowicjusza.png"));
            sklepTarcze.Add(new Tarcza("Tarcza bojowa", 1, 2000, 13, "ms-appx:///Assets//Tarcze//tarczaBojowa.png"));
            sklepTarcze.Add(new Tarcza("Tarcza wikinga", 1, 3900, 17, "ms-appx:///Assets//Tarcze//tarczaWikinga.png"));
            sklepTarcze.Add(new Tarcza("Diamentowa tarcza", 1, 7000, 25, "ms-appx:///Assets//Tarcze//diamentowaTarcza.png"));
            #endregion

            #region Buty
            sklepButy.Add(new Buty("Buty Nowicjusza", 1, 250, 1, "ms-appx:///Assets//Buty//butyNowicjusza.png"));
            sklepButy.Add(new Buty("Skorzane Buty", 1, 450, 4, "ms-appx:///Assets//Buty//skorzaneButy.png"));
            sklepButy.Add(new Buty("Rycerskie Buty", 1, 900, 12, "ms-appx:///Assets//Buty//rycerskieButy.png"));
            sklepButy.Add(new Buty("Buty Smoka", 1, 1100, 16, "ms-appx:///Assets//Buty//butySmoka.png"));
            sklepButy.Add(new Buty("Diamentowe Buty", 1, 1300, 20, "ms-appx:///Assets//Buty//diamentoweButy.png"));
            #endregion

            #region Helmy
            sklepHelmy.Add(new Hełm("Helm Nowicjusza", 1, 300, 1, "ms-appx:///Assets//Helmy//helmNowicjusza.png"));
            sklepHelmy.Add(new Hełm("Helm Mnicha", 1, 1150, 9, "ms-appx:///Assets//Helmy//helmMnicha.png"));
            sklepHelmy.Add(new Hełm("Rycerski Helm", 1, 2500, 17, "ms-appx:///Assets//Helmy//rycerskiHelm.png"));
            sklepHelmy.Add(new Hełm("Helm Barbarzyńcy", 1, 4100, 22, "ms-appx:///Assets//Helmy//helmBarbarzyncy.png"));
            sklepHelmy.Add(new Hełm("KaKaKask", 1, 10000, 35, "ms-appx:///Assets//Helmy//KaKaKask.png"));
            #endregion

            #region Spodnie
            sklepSpodnie.Add(new Spodnie("Porwane Gacie", 1, 500, 1, "ms-appx:///Assets//Spodnie//porwaneGacie.png"));
            sklepSpodnie.Add(new Spodnie("Spodnie Kowala", 1, 1500, 6, "ms-appx:///Assets//Spodnie//spodnieKowala.png"));
            sklepSpodnie.Add(new Spodnie("Jeansy", 1, 4500, 13, "ms-appx:///Assets//Spodnie//jeansy.png"));
            sklepSpodnie.Add(new Spodnie("Skórzane Spodnie", 1, 10000, 17, "ms-appx:///Assets//Spodnie//skorzaneSpodnie.png"));
            sklepSpodnie.Add(new Spodnie("Tripaloski", 1, 50000, 25, "ms-appx:///Assets//Spodnie//adasie.png"));
            #endregion

            #region Zbroje
            sklepZbroje.Add(new Zbroja("Skórzana Zbroja", 1, 700, 1, "ms-appx:///Assets//Zbroje//skorzanaZbroja.png"));
            sklepZbroje.Add(new Zbroja("Zbroja Płytowa", 1, 1900, 6, "ms-appx:///Assets//Zbroje//plytowaZbroja.png"));
            sklepZbroje.Add(new Zbroja("Żelazna Zbroja", 1, 2400, 13, "ms-appx:///Assets//Zbroje//zelaznaZbroja.png"));
            sklepZbroje.Add(new Zbroja("Zbroja Dowódcy", 1, 3900, 17, "ms-appx:///Assets//Zbroje//zbrojaDowodcy.png"));
            sklepZbroje.Add(new Zbroja("Zbroja Assasyna", 1, 6500, 25, "ms-appx:///Assets//Zbroje//zbrojaAsasyna.png"));
            #endregion

        }


        private void wroc_Btn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }
        private void Bronie_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sklepListBox.ItemsSource = sklepMiecze;
        }

        private void helmy_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sklepListBox.ItemsSource = sklepHelmy;
        }

        private void zbroje_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sklepListBox.ItemsSource = sklepZbroje;
        }

        private void spodnie_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sklepListBox.ItemsSource = sklepSpodnie;
        }

        private void buty_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sklepListBox.ItemsSource = sklepButy;
        }

        private void Tarcze_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sklepListBox.ItemsSource = sklepTarcze;
        }

        private void kup_Btn_Click(object sender, RoutedEventArgs e)
        {
            int wybrany = sklepListBox.SelectedIndex;

            if (sklepListBox.ItemsSource == sklepMiecze)
            {
                if(Bohater.Instancja.Ekwipunek.Contains(sklepMiecze.ElementAt(wybrany)) == false)
                {
                    if (Bohater.Instancja.Zloto >= sklepMiecze.ElementAt(wybrany).Cena)
                    {
                        Bohater.Instancja.Ekwipunek.Add(sklepMiecze.ElementAt(wybrany));
                        Bohater.Instancja.Zloto -= sklepMiecze.ElementAt(wybrany).Cena;
                    }
                }
            }
            else if (sklepListBox.ItemsSource == sklepHelmy)
            {
                if (Bohater.Instancja.Zloto >= sklepHelmy.ElementAt(wybrany).Cena && Bohater.Instancja.Ekwipunek.Contains(sklepHelmy.ElementAt(wybrany)) == false)
                {
                    Bohater.Instancja.Ekwipunek.Add(sklepHelmy.ElementAt(wybrany));
                    Bohater.Instancja.Zloto -= sklepHelmy.ElementAt(wybrany).Cena;
                }
            }

            else if (sklepListBox.ItemsSource == sklepZbroje)
            {
                if (Bohater.Instancja.Zloto >= sklepZbroje.ElementAt(wybrany).Cena && Bohater.Instancja.Ekwipunek.Contains(sklepZbroje.ElementAt(wybrany)) == false)
                {
                    Bohater.Instancja.Ekwipunek.Add(sklepZbroje.ElementAt(wybrany));
                    Bohater.Instancja.Zloto -= sklepZbroje.ElementAt(wybrany).Cena;
                }
            }

            else if (sklepListBox.ItemsSource == sklepSpodnie)
            {
                if (Bohater.Instancja.Zloto >= sklepSpodnie.ElementAt(wybrany).Cena && Bohater.Instancja.Ekwipunek.Contains(sklepSpodnie.ElementAt(wybrany)) == false)
                {
                    Bohater.Instancja.Ekwipunek.Add(sklepSpodnie.ElementAt(wybrany));
                    Bohater.Instancja.Zloto -= sklepSpodnie.ElementAt(wybrany).Cena;
                }
            }

            else if (sklepListBox.ItemsSource == sklepTarcze)
            {
                if (Bohater.Instancja.Zloto >= sklepTarcze.ElementAt(wybrany).Cena && Bohater.Instancja.Ekwipunek.Contains(sklepTarcze.ElementAt(wybrany)) == false)
                {
                    Bohater.Instancja.Ekwipunek.Add(sklepTarcze.ElementAt(wybrany));
                    Bohater.Instancja.Zloto -= sklepTarcze.ElementAt(wybrany).Cena;
                }
            }
            else if (sklepListBox.ItemsSource == sklepButy)
            {
                if (Bohater.Instancja.Zloto >= sklepButy.ElementAt(wybrany).Cena && Bohater.Instancja.Ekwipunek.Contains(sklepButy.ElementAt(wybrany)) == false)
                {
                    Bohater.Instancja.Ekwipunek.Add(sklepButy.ElementAt(wybrany));
                    Bohater.Instancja.Zloto -= sklepButy.ElementAt(wybrany).Cena;
                }
            }
        }
    }
}

