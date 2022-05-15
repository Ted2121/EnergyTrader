using EnergyTraderWPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand DashBoardViewCommand { get; set; }
        public RelayCommand WindFarmViewCommand { get; set; }
        public RelayCommand SolarParkViewCommand { get; set; }
        public DashboardViewModel DashboardVM { get; set; }
        public WindFarmViewModel WindFarmVM { get; set; }
        public SolarParkViewModel SolarParkVM { get; set; }

        private object _currentViewModel;

        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            DashboardVM = ViewModelFactory.GetDashboardViewModel();
            WindFarmVM = ViewModelFactory.GetWindFarmViewModel();
            SolarParkVM = ViewModelFactory.GetSolarParkViewModel();

            CurrentViewModel = DashboardVM;

            DashBoardViewCommand = new RelayCommand(o => 
            { 
                CurrentViewModel = DashboardVM;
            });

            WindFarmViewCommand = new RelayCommand(o =>
            {
                CurrentViewModel = WindFarmVM;
            });

            SolarParkViewCommand = new RelayCommand(o =>
            {
                CurrentViewModel = SolarParkVM;
            });

        }

      
    }
}
