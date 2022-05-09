using EnergyTraderWPF.Core;
using EnergyTraderWPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.ViewModel
{
    class SolarParkViewModel : ObservableObject
    {

        SolarParkModel SolarPark { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
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

        private string _areaSize;

        public string AreaSize
        {
            get { return _areaSize; }
            set
            {
                _areaSize = value;
                OnPropertyChanged();
            }
        }

        private int _outputDuration;

        public int OutputDuration
        {
            get { return _outputDuration; }
            set
            {
                _outputDuration = value;
                OnPropertyChanged();
            }
        }

        private int _totalCapacity;

        public int TotalCapacity
        {
            get { return _totalCapacity; }
            set
            {
                _totalCapacity = value;
                OnPropertyChanged();
            }
        }

        private int _expectedProduction;

        public int ExpectedProduction
        {
            get { return _expectedProduction; }
            set
            {
                _expectedProduction = value;
                OnPropertyChanged();
            }
        }

        private DateTime _sunrise;

        public DateTime Sunrise
        {
            get { return _sunrise; }
            set
            {
                _sunrise = value;
                OnPropertyChanged();
            }
        }

        private DateTime _sunset;

        public DateTime Sunset
        {
            get { return _sunset; }
            set
            {
                _sunset = value;
                OnPropertyChanged();
            }
        }



        public SolarParkViewModel()
        {

        }


    }
}
