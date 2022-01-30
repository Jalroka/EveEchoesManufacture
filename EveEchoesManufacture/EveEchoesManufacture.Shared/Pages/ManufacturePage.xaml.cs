using EveEchoesManufacture.ViewModels;
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
    public sealed partial class ManufacturePage : Page
    {
        private ManufactureViewModel vm;
        public ManufacturePage()
        {
            this.InitializeComponent();
            vm = this.DataContext as ManufactureViewModel;
        }

        private void ItemTypeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.ItemTypePopulate((string)ItemTypeSelector.SelectedItem);
        }

        private void ItemSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.ItemSelected((string)ItemSelector.SelectedItem);
        }

        private void Efficiency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.EffiencyChanged();
        }

        private void SaveUpdate_Click(object sender, RoutedEventArgs e)
        {
            vm.SaveUpdate();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
