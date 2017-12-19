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
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Fish : Page
    {
        public Fish()
        {
            this.InitializeComponent();
        }

        private void Home_Bttn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }


        private void SparklingWine_Click(object sender, RoutedEventArgs e)
        {
            TextSparklingWine.Visibility = Visibility.Visible;
            TextRichWhiteWine.Visibility = Visibility.Collapsed;
            TextDryWhiteWine.Visibility = Visibility.Collapsed;

        }

        private void RichWhiteWine_Click(object sender, RoutedEventArgs e)
        {
            TextSparklingWine.Visibility = Visibility.Collapsed;
            TextRichWhiteWine.Visibility = Visibility.Visible;
            TextDryWhiteWine.Visibility = Visibility.Collapsed;
        }

        private void DryWhiteWine_Click(object sender, RoutedEventArgs e)
        {
            TextSparklingWine.Visibility = Visibility.Collapsed;
            TextRichWhiteWine.Visibility = Visibility.Collapsed;
            TextDryWhiteWine.Visibility = Visibility.Visible;
        }

        public async void Make_File()
        {
            StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = await storageFolder.CreateFileAsync("Comments.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);
        }



        private async void Send_Click(object sender, RoutedEventArgs e)
        {

            Make_File();

            String Comment = CommentSection.Text;
            String food = FoodCommentSection.Text;
            String wine = WineCommentSection.Text;

            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile myFile = await storageFolder.GetFileAsync("Comments.txt");

            await Windows.Storage.FileIO.AppendTextAsync(myFile, Environment.NewLine);
            await Windows.Storage.FileIO.AppendTextAsync(myFile, "FISH COMMENT" + Environment.NewLine);
            await Windows.Storage.FileIO.AppendTextAsync(myFile, wine + Environment.NewLine);
            await Windows.Storage.FileIO.AppendTextAsync(myFile, food + Environment.NewLine);
            await Windows.Storage.FileIO.AppendTextAsync(myFile, Comment + Environment.NewLine);


            WineCommentSection.Text = "";
            FoodCommentSection.Text = "";
            CommentSection.Text = "";
        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;


        }

    }
}
