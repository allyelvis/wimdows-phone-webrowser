using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace SimpleBrowser
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the URL entered in the TextBox
            Browser.Navigate(new Uri(UrlTextBox.Text, UriKind.Absolute));
        }
    }
}
