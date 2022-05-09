using EnergyTraderWPF.API;
using EnergyTraderWPF.Core;
using EnergyTraderWPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.ViewModel
{
    public class WindFarmViewModel : ObservableObject
    {
        List<double> wind = new List<double>();
        
        WindFarm WindFarm { get; set; }
        
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value;
                OnPropertyChanged();
            }
        }

        private int _numberOfTurbines;

        public int NumberOfTurbines
        {
            get { return _numberOfTurbines; }
            set
            {
                _numberOfTurbines = value;
                OnPropertyChanged();
            }
        }

        private int _turbineCapacity;

        public int TurbineCapacity
        {
            get { return _turbineCapacity; }
            set
            {
                _turbineCapacity = value;
                OnPropertyChanged();
            }
        }

        private int _totalNominalPower;

        public int TotalNominalPower
        {
            get { return _totalNominalPower; }
            set
            {
                _totalNominalPower = value;
                OnPropertyChanged();
            }
        }

        //private string _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        _name = value;
        //        OnPropertyChanged();
        //    }
        //}

        //private string _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        _name = value;
        //        OnPropertyChanged();
        //    }
        //}
        public WindFarmViewModel()
        {
            WindFarm = new WindFarm("Nysted", 72, 2300);
            NumberOfTurbines = WindFarm.NumberOfTurbines;
           

        }
    }
}
