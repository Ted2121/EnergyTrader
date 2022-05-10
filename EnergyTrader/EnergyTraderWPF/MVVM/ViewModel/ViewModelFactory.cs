using EnergyTraderWPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApi;

namespace EnergyTraderWPF.MVVM.ViewModel
{
    public class ViewModelFactory
    {

        private ViewModelFactory() { }

        public static WindFarmModel WindFarmModel { get; set; }
        public static SolarParkModel SolarParkModel { get; set; } = new SolarParkModel("Holstebro Solar Park", 56.38, 8.49, 222.0, 207000);
        public double Wind { get; set; }
        public static DashboardViewModel GetDashboardViewModel()
        {
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

            return dashboardViewModel; 
        }

        public static WindFarmViewModel GetWindFarmViewModel()
        {
            //WindFarmModel = GetWindFarmModel();

            // calling the API here to get wind information
            double wind = Math.Round(WeatherInformationWebService.GetWindInformation(), 2);
          
            WindFarmViewModel windFarmViewModel = new WindFarmViewModel();
            windFarmViewModel.Wind = wind;
            windFarmViewModel.WindFarm = WindFarmModel;
            return windFarmViewModel;
        }

        public static SolarParkViewModel GetSolarParkViewModel()
        {
            SolarParkViewModel solarParkViewModel = new SolarParkViewModel();

            return solarParkViewModel;
        }

       
        public static WindFarmModel GetWindFarmModel()
        {
            WindFarmModel = new WindFarmModel("Nysted Wind Farm", 72, 2300, 54.55, 11.71);

            return WindFarmModel;
        }
        
    }
}
