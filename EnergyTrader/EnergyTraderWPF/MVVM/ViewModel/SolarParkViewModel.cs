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
    public class SolarParkViewModel : ObservableObject
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

        private TimeSpan _outputDuration;

        public TimeSpan OutputDuration
        {
            get { return _outputDuration; }
            set
            {
                _outputDuration = value;
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
            SolarPark = new SolarParkModel("Holstebro Solar Park", 56.38, 8.49, 222.0, 207000);
            int sunriseInSeconds = WeatherInformationProcessor.
                GetSunInformation().Item1;
            int sunsetInSeconds = WeatherInformationProcessor.
                GetSunInformation().Item2;  
            Name = SolarPark.Name;
            Lat = SolarPark.Lat;
            Lon = SolarPark.Lon;
            AreaSize = SolarPark.AreaSize;
            OutputDuration = SolarPark.CalculateOutputDuration(Sunrise, Sunset);
            SolarPark.OutputDuration = OutputDuration;
            TotalNominalPower = SolarPark.TotalNominalPower;
            ExpectedProduction = Math.Round(SolarPark.CalculateExpectedProduction(SolarPark.
                CalculateOutputDurationInSeconds(sunriseInSeconds, sunsetInSeconds)), 2);
            SolarPark.ExpectedProduction = ExpectedProduction;
            
            Sunrise = WeatherInformationProcessor.
                convertSecondsToDateTime(sunriseInSeconds);

            Sunset = WeatherInformationProcessor.
                convertSecondsToDateTime(sunsetInSeconds);


        }




    }
}
