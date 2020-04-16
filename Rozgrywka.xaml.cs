using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RPG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Rozgrywka : Page
    {
        public Rozgrywka()
        {
            this.InitializeComponent();
        }

        private void postac_menuItem_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {

        }

        private void postac_menuItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
