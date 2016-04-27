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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HamburgerMenu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ViewModels.MainPageViewModel vm = new ViewModels.MainPageViewModel();
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = vm;
            listBox.ItemsSource = vm.HamburgerMenuItems;
            listBox.SelectedIndex = 0;
        }

        private void hambugerBtn_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var index = (sender as ListBox).SelectedIndex;
            var item = vm.HamburgerMenuItems[index];

            frame.Navigate(item.TargetFrame);
            titleTB.Text = item.Text.ToUpper();

            splitView.IsPaneOpen = false;
        }

    }
}
