﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.WindowManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using RPG.Dane;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RPG
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        Frame appWindowFrame = new Frame();

        //((Frame) Window.Current.Content).ActualWidth <= 1200
        public MainPage()
        {
            this.InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WyborPostaci));
        }

        private void Zakoncz_BTN_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if ((((Frame)Window.Current.Content).ActualWidth <= 800) || (((Frame)Window.Current.Content).ActualHeight <= 600))
            {
                NazwaGry.FontSize = 50;
                NowaGra_Btn.FontSize = 30;
                Wznow_Btn.FontSize = 30;
                Zakoncz_Btn.FontSize = 30;
            }
            else if((((Frame)Window.Current.Content).ActualWidth <= 1370) || (((Frame)Window.Current.Content).ActualHeight <= 770))
            {
                NazwaGry.FontSize = 90;
                NowaGra_Btn.FontSize = 60;
                Wznow_Btn.FontSize = 60;
                Zakoncz_Btn.FontSize = 60;
            }
            else if((((Frame)Window.Current.Content).ActualWidth <= 1920 ) || (((Frame)Window.Current.Content).ActualHeight <= 1080))
            {
                NazwaGry.FontSize = 310;
                NowaGra_Btn.FontSize = 100;
                Wznow_Btn.FontSize = 100;
                Zakoncz_Btn.FontSize = 100;
            }
            else
            {
                NazwaGry.FontSize = 50;
                NowaGra_Btn.FontSize = 30;
                Wznow_Btn.FontSize = 30;
                Zakoncz_Btn.FontSize = 30;
            }

        }
        
        private async void Wznow_Btn_Click(object sender, RoutedEventArgs e)
        {
            var local = ApplicationData.Current.LocalFolder;
            StorageFile file = await local.GetFileAsync("SBXStaty");
            StorageFile file2 = await local.GetFileAsync("SBXEkwipunek");

            string str = await FileIO.ReadTextAsync(file);
            string str2 = await FileIO.ReadTextAsync(file2);

            string[] postacStaty = str.Split(",");
            string[] postacEQ = str2.Split("\n");
           // string[] przedmiot = postacEQ[1].Split(' ');

            Bohater.CreateStaticInstance(postacStaty[0], postacStaty[1], int.Parse(postacStaty[2]), int.Parse(postacStaty[3]), int.Parse(postacStaty[4]), int.Parse(postacStaty[5]), int.Parse(postacStaty[6]), int.Parse(postacStaty[7]));
            Bohater.Instancja.Zloto = int.Parse(postacStaty[8]);

          /*  for(int i = 0; i < postacEQ.Length; i++)
            {
                string[] przedmiot = postacEQ[i].Split(' ');
                Bohater.Instancja.Ekwipunek.Add(postacEQ[0], postacEQ[0], postacEQ[0], postacEQ[0], postacEQ[0]);

            }*/



            this.Frame.Navigate(typeof(Rozgrywka));
        }
    }
}
