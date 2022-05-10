using EnergyTraderWPF.Core;
using EnergyTraderWPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApi;

namespace EnergyTraderWPF.MVVM.ViewModel
{
    public class WindFarmViewModel : ObservableObject
    {
        

        WindFarmModel WindFarm { get; set; }
        
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

        private double _lat;

        public double Lat
        {
            get { return _lat; }
            set
            {
                _lat = value;
                OnPropertyChanged();
            }
        }

        private double _lon;

        public double Lon
        {
            get { return _lon; }
            set
            {
                _lon = value;
                OnPropertyChanged();
            }
        }

        private double _effectivePower;

        public double EffectivePower
        {
            get { return _effectivePower; }
            set
            {
                _effectivePower = value;
                OnPropertyChanged();
            }
        }

        private double _totalEffectivePower;

        public double TotalEffectivePower
        {
            get { return _totalEffectivePower; }
            set
            {
                _totalEffectivePower = value;
                OnPropertyChanged();
            }
        }

        private double _expectedLoadRate;

        public double ExpectedLoadRate
        {
            get { return _expectedLoadRate; }
            set
            {
                _expectedLoadRate = value;
                OnPropertyChanged();
            }
        }

        private double _expectedProduction;

        public double ExpectedProduction
        {
            get { return _expectedProduction; }
            set
            {
                _expectedProduction = value;
                OnPropertyChanged();
            }
        }

        private double _wind;

        public double Wind
        {
            get { return _wind; }
            set
            {
                _wind = value;
                OnPropertyChanged();
            }
        }

        public WindFarmViewModel()
        {
           
            WindFarm = new WindFarmModel("Nysted Wind Farm", 72, 2300, 54.55, 11.71);
            Name = WindFarm.Name;
            NumberOfTurbines = WindFarm.NumberOfTurbines;
            TurbineCapacity = WindFarm.TurbineCapacity;
            TotalNominalPower = WindFarm.CalculateTotalNominalPower();
            Lat = WindFarm.Lat;
            Lon = WindFarm.Lon;

            Wind = Math.Round(WeatherInformationClient.GetWindInformation(), 2);
           
            EffectivePower = Math.Round(WindFarm.GetInterpolatedPower(Wind), 2);
            WindFarm.EffectivePower = EffectivePower;
            TotalEffectivePower = Math.Round(WindFarm.CalculateTotalEffectivePower(), 2);
            WindFarm.TotalEffectivePower = TotalEffectivePower;
            ExpectedLoadRate = Math.Round(WindFarm.CalculateExpectedLoadRate(Wind), 2);
            WindFarm.ExpectedLoadRate = ExpectedLoadRate;
            ExpectedProduction = Math.Round(WindFarm.CalculateExpectedProduction(), 2);
            WindFarm.ExpectedProduction = ExpectedProduction;

        }

       
    }
}
