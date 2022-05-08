﻿using EnergyTraderWPF.API;
using EnergyTraderWPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnergyTraderWPF.MVVM.View
{
    /// <summary>
    /// Interaction logic for WindFarmView.xaml
    /// </summary>
    public partial class WindFarmView : UserControl
    {
        public WindFarmView()
        {
            WindFarm windFarm = new WindFarm("Nysted", 72, 2300);
            InitializeComponent();
            
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WeatherInformationProcessor.LoadWeatherInformation();
        }
    }
}
