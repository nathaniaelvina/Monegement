using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Monegement
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

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
        private async void IconsListBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (transactionListBox.IsSelected) { DasboardFrame.Navigate(typeof(transactionPage)); }
            else if (chartListBox.IsSelected) { DasboardFrame.Navigate(typeof(chartPage)); }
            else if (wishListBox.IsSelected) { DasboardFrame.Navigate(typeof(wishlistPage)); }
            else if (settingBox.IsSelected) { DasboardFrame.Navigate(typeof(wishlistPage)); }
            else if (logoutBox.IsSelected)
            {
                //tambain konfirmasi
                int newViewId = 0;
                var frame = new Frame();
                frame.Navigate(typeof(LoginPage));
                Window.Current.Content = frame;
                Window.Current.Activate();
                newViewId =  ApplicationView.GetForCurrentView().Id;


            }

        }

       void YesCommand(IUICommand command)
        {

        }
        void NoCommand(IUICommand command)
        {

        }
    }
}
