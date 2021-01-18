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
using System.Data.SQLite;


// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LibraryApp
{
    public sealed partial class CustomerSignUp : ContentDialog
    {
        public ComboBoxItem item;
        public SQLiteConnection SQ;
        public CustomerSignUp()
        {
            this.InitializeComponent();

            SQ = new SQLiteConnection("Data Source=StoreDatabase.sqlite3");
            if (!File.Exists("./StoreDatabase.sqlite3"))
            {
                SQLiteConnection.CreateFile("StoreDatabase.sqlite3");
            }
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            var ans = item.Content.ToString();
        }

        private void accountComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            item = (ComboBoxItem)combo.SelectedItem;
            var y = item.Content.ToString();
            if (y== "Administrator")
            {
                Selected3.Visibility = Visibility.Visible;
                Selected2.Visibility = Visibility.Collapsed;
                Selected1.Visibility = Visibility.Collapsed;
            }
            else if (y == "Student")
            {
                Selected2.Visibility = Visibility.Visible;
                Selected1.Visibility = Visibility.Collapsed;
                Selected3.Visibility = Visibility.Collapsed;
            }
            else if (y=="Customer")
            {
                Selected2.Visibility = Visibility.Collapsed;
                Selected3.Visibility = Visibility.Collapsed;
                Selected1.Visibility = Visibility.Visible;
            }
        }
    }
}
