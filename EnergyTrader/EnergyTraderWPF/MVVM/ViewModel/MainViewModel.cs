using EnergyTraderWPF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand DashBoardViewCommand { get; set; }
        public RelayCommand WindTurbinesViewCommand { get; set; }
        public RelayCommand SolarPanelsViewCommand { get; set; }
        public DashboardViewModel DashboardVM { get; set; }
        public WindTurbinesViewModel WindTurbinesVM { get; set; }
        public SolarPanelsViewModel SolarPanelsVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            DashboardVM = new DashboardViewModel();
            WindTurbinesVM = new WindTurbinesViewModel();
            SolarPanelsVM = new SolarPanelsViewModel();
            CurrentView = DashboardVM;

            DashBoardViewCommand = new RelayCommand(o => 
            { 
                CurrentView = DashboardVM;
            });

            WindTurbinesViewCommand = new RelayCommand(o =>
            {
                CurrentView = WindTurbinesVM;
            });

            SolarPanelsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SolarPanelsVM;
            });

        }
    }
}
