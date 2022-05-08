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
        //public RelayCommand SolarParkViewCommand { get; set; }
        public DashboardViewModel DashboardVM { get; set; }
        public WindFarmViewModel WindFarmVM { get; set; }
        
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
            WindFarmVM = new WindFarmViewModel();
            CurrentView = DashboardVM;

            DashBoardViewCommand = new RelayCommand(o => 
            { 
                CurrentView = DashboardVM;
            });

            WindFarmViewCommand = new RelayCommand(o =>
            {
                CurrentView = WindFarmVM;
            });

            //SolarParkViewCommand = new RelayCommand(o =>
            //{
            //    CurrentView = SolarParkVM;
            //});

        }
    }
}
