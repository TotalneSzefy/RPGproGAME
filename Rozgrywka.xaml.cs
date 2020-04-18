using RPG.Dane;
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
        Bohater bohater { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            bohater = (Bohater)e.Parameter;
        }

        public Rozgrywka()
        {
            this.InitializeComponent();
        }

        private void postac_menuItem_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {

        }

        private void postac_menuItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rozgrywka));
        }

        private void NavigationPanel_Wyjdz_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Karczma_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Karczma));
        }

        private void zwiekszSila_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            bohater.Sila++;
        }

        private void zwiekszInt_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            bohater.Inteligencja++;
        }

        private void dodajZrecznosc_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            bohater.Zrecznosc++;
        }

        private void dodajWytrzymalosc_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            bohater.Wytrzymalosc++;
        }

        private void Ekwipunek_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            Hełm nowyHelm = (Hełm)Ekwipunek_ListBox.SelectedItem;
            if (nowyHelm.Zalozony == false)
            {
                nowyHelm.Zalozony = true;
                bohater.Helm = nowyHelm;
            }
            else
            {
                nowyHelm.Zalozony = false;
                bohater.Helm = null;
            }
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
                rozmiary.PrzyciskiFontSize1 = 42;

            }
        }
    }
}
