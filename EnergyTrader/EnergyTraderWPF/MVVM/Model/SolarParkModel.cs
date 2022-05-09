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
        public int OutputDuration { get; set; }
        public int TotalCapacity { get; set; }
        public double ExpectedProduction { get; set; }
        public SolarParkModel(string name, double lat, double lon, double areaSize, int totalCapacity)
        {
            Name = name;
            Lat = lat;
            Lon = lon;
            AreaSize = areaSize;
            TotalCapacity = totalCapacity;

        }

        public int CalculateOutputDuration(int sunrise, int sunset)
        {
            // we calculate the difference between sunset and sunrise in seconds
            return sunset - sunrise;
        }

        public double CalculateExpectedProduction(int outputDuration)
        {
            // we multiply the total capacity of the solar panels
            // with the output duration (transformed from seconds to hours) and
            // with an efficiency loss coeficient
            return TotalCapacity * (outputDuration / 3600) * 0.75;
        }
    }
}
