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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Red_Meat_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Red_Meat), null);
        }

        private void White_Meat_Click(object sender, RoutedEventArgs e)
        {
           //  White_Meat.BorderBrush = Brush.Black ;
            Frame.Navigate(typeof(White_Meat), null);
        }

        private void Smoke_Meat_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Smoked_Meat), null);
        }

        private void Fish_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Fish), null);
        }
        private void ShellFish_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Shell_Fish), null);
        }

        private void Carbs_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(carbs), null);

        }

        private void Desert_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Desert), null);
        }

        private void Cheese_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Cheese), null);
        }

        private void Vegetables_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Vegetables), null);
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login), null);
        }
    }
}
