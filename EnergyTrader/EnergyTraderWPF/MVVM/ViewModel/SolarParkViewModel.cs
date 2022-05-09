using EnergyTraderWPF.API;
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

        private double _areaSize;

        public double AreaSize
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
            SolarPark = new SolarParkModel("Holstebro Solar Park", 56.38, 8.49, 222.0, 207);
            int sunriseInSeconds = WeatherInformationProcessor.
                GetSunInformation().Item1;
            int sunsetInSeconds = WeatherInformationProcessor.
                GetSunInformation().Item2;  
            Name = SolarPark.Name;
            Lat = SolarPark.Lat;
            Lon = SolarPark.Lon;
            AreaSize = SolarPark.AreaSize;
            OutputDuration = SolarPark.CalculateOutputDuration(sunriseInSeconds, sunsetInSeconds);
            SolarPark.OutputDuration = OutputDuration;
            TotalCapacity = SolarPark.TotalCapacity;
            ExpectedProduction = Math.Round(SolarPark.CalculateExpectedProduction(OutputDuration), 2);

            
            Sunrise = WeatherInformationProcessor.
                convertSecondsToDateTime(sunriseInSeconds);

            Sunset = WeatherInformationProcessor.
                convertSecondsToDateTime(sunsetInSeconds);


        }




    }
}
