using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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
using Newtonsoft.Json;
using Windows.Storage;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyProject
{

    public sealed partial class carbs : Page
    {
        public carbs()
        {
            this.InitializeComponent();
            //this.Loaded += Carbs_Loaded;
        }

        //private void Carbs_Loaded(object sender, RoutedEventArgs e)
        //{
        //    if( myList == null)
        //    {
        //        // fill the list
        //        myList = new List<reviesClass>();
        //        // read the json file here.
        //        readParseReviewFile();

        //    }

        //}

        //private void readParseReviewFile()
        //{
        //    throw new NotImplementedException();
        //}

        private void Home_Bttn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        private void BoldRedWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Visible;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextSparklingWine.Visibility = Visibility.Collapsed;
            TextRichWhiteWine.Visibility = Visibility.Collapsed;
            TextDryWhiteWine.Visibility = Visibility.Collapsed;

        }

        private void DesertWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Visible;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextSparklingWine.Visibility = Visibility.Collapsed;
            TextRichWhiteWine.Visibility = Visibility.Collapsed;
            TextDryWhiteWine.Visibility = Visibility.Collapsed;
        }

        private void RedWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Visible;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextSparklingWine.Visibility = Visibility.Collapsed;
            TextRichWhiteWine.Visibility = Visibility.Collapsed;
            TextDryWhiteWine.Visibility = Visibility.Collapsed;
        }

        private void LightRedWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Visible;
            TextSparklingWine.Visibility = Visibility.Collapsed;
            TextRichWhiteWine.Visibility = Visibility.Collapsed;
            TextDryWhiteWine.Visibility = Visibility.Collapsed;
        }

        private void SparklingWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextSparklingWine.Visibility = Visibility.Visible;
            TextRichWhiteWine.Visibility = Visibility.Collapsed;
            TextDryWhiteWine.Visibility = Visibility.Collapsed;
        }

        private void RichWhiteWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextSparklingWine.Visibility = Visibility.Collapsed;
            TextRichWhiteWine.Visibility = Visibility.Visible;
            TextDryWhiteWine.Visibility = Visibility.Collapsed;
        }

        private void DryWhiteWine_Click(object sender, RoutedEventArgs e)
        {
            TextBoldRedWine.Visibility = Visibility.Collapsed;
            TextDesertWine.Visibility = Visibility.Collapsed;
            TextRedWine.Visibility = Visibility.Collapsed;
            TextLightRedWine.Visibility = Visibility.Collapsed;
            TextSparklingWine.Visibility = Visibility.Collapsed;
            TextRichWhiteWine.Visibility = Visibility.Collapsed;
            TextDryWhiteWine.Visibility = Visibility.Visible;
        }

        public class Pairing
        {
            public String Food;
            public String Wine;
            public String Comment;


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
            await Windows.Storage.FileIO.AppendTextAsync(myFile, "CARBOHYDRATE COMMENT" + Environment.NewLine);
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
