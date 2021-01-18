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

namespace LibraryApp
{
    
    public sealed partial class MainPage : Page
    {
        public ComboBoxItem item;
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        private async void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerSignUp c =new  CustomerSignUp();
            await c.ShowAsync();
        }
        private void accountComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ResultTextBlock == null) return;
            var combo = (ComboBox)sender;
            item = (ComboBoxItem)combo.SelectedItem;
            ResultTextBlock.Text = item.Content.ToString();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
