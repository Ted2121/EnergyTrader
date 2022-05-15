using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.Model
{
    public class SolarParkModel
    {

        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double AreaSize { get; set; }
        public TimeSpan OutputDuration { get; set; }
        public int TotalNominalPower { get; set; }
        public double ExpectedProduction { get; set; }
        public SolarParkModel(string name, double lat, double lon, double areaSize, int totalNominalPower)
        {
            Name = name;
            Lat = lat;
            Lon = lon;
            AreaSize = areaSize;
            TotalNominalPower = totalNominalPower;

        }
        public double CalculateExpectedProduction(int outputDuration)
        {
            // we multiply the total capacity of the solar panels
            // with the output duration (transformed from seconds to hours) and
            // with an average efficiency of conversion
            return TotalNominalPower * (outputDuration / 3600) * 0.22;
        }

        public TimeSpan CalculateOutputDuration(DateTime sunrise, DateTime sunset)
        {
            // we calculate the difference between sunset and sunrise and return it as a TimeSpan object
            return sunset.Subtract(sunrise);
        }

        public int CalculateOutputDurationInSeconds(int sunrise, int sunset)
        {
            // we calculate the difference between sunset and sunrise in seconds
            return sunset - sunrise;
        }

    }
}
