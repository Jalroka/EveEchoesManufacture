using CsvHelper;
using EveEchoesManufacture.Contracts;
using EveEchoesManufacture.Pages;
using EveEchoesManufacture.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace EveEchoesManufacture
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel vm;
        public MainPage()
        {
            this.InitializeComponent();
            vm= this.DataContext as MainPageViewModel;
            contentView.Navigate(typeof(TileNavPage));
        }

        private void ItemTypeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //VM.ItemTypePopulate((string)ItemTypeSelector.SelectedItem);
        }

        private void ItemSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //VM.ItemSelected((string)ItemSelector.SelectedItem);
        }



        private void SaveUpdate_Click(object sender, RoutedEventArgs e)
        {
            //vm.SaveUpdate();
        }
    }
}
