using System;
using System.Collections.Generic;
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
    public sealed partial class WyborPostaci : Page
    {
        public WyborPostaci()
        {
            this.InitializeComponent();
        }

        Rozmiary rozmiary = new Rozmiary();



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
       
      

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if ((((Frame)Window.Current.Content).ActualWidth <= 600) || (((Frame)Window.Current.Content).ActualHeight <= 550))
            {
                rozmiary.StatyFontSize1 = 7;
            }
            else if ((((Frame)Window.Current.Content).ActualWidth <= 800) || (((Frame)Window.Current.Content).ActualHeight <= 600))
            {
                rozmiary.StatyFontSize1 = 20;
            }
            else if ((((Frame)Window.Current.Content).ActualWidth <= 1370) || (((Frame)Window.Current.Content).ActualHeight <= 770))
            {
                rozmiary.StatyFontSize1 = 27;
            }
            else if ((((Frame)Window.Current.Content).ActualWidth < 1920) || (((Frame)Window.Current.Content).ActualHeight < 1080))
            {
                rozmiary.StatyFontSize1 = 40;
            }
         
        }
    }
}
