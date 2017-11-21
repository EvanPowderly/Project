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

namespace MyProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Smoked_Meat : Page
    {
        public Smoked_Meat()
        {
            this.InitializeComponent();
        }

        private void Home_Bttn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        private void BoldRedWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Visible;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextSweetWhiteWine.Visibility = Visibility.Collapsed;

        }

        private void DesertWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Visible;
            TextSweetWhiteWine.Visibility = Visibility.Collapsed;
        }

        private void RedWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Visible;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextSweetWhiteWine.Visibility = Visibility.Collapsed;
        }

        private void LightRedWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Visible;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextSweetWhiteWine.Visibility = Visibility.Collapsed;
        }

        private void SweetWhiteWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextSweetWhiteWine.Visibility = Visibility.Visible;
        }
    }
}
