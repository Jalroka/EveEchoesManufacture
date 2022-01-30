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

namespace EveEchoesManufacture.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TileNavPage : Page
    {
        public TileNavPage()
        {
            this.InitializeComponent();
        }

        private void Manufacture_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ManufacturePage));
        }
        private void Costs_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate (typeof(CostsPage));
        }
        private void Skills_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SkillsPage));
        }
        private void Reprocess_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ReprocessPage));
        }
    }
}
