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
using EnergyTraderWPF.MVVM.ViewModel;

namespace EnergyTraderWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            //ApiHelper.InitializeClient();
            
        }

        //private async void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Root root = await WeatherInformationProcessor.LoadWeatherInformationAsync();
        //    WindFarmViewModel.Wind = root.wind.speed;
        //}
    }
}
