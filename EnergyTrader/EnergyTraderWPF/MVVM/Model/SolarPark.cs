using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.Model
{
    public class SolarPark
    {
        public List<SolarPanel> SolarPanels { get; set; }
        // hardcoded values for the purpose of this prototype
        public string Location { get; } = "Aabenraa";
        public double Lat { get; } = 55.04;
        public double Lon { get; } = 9.41;

        public SolarPark(List<SolarPanel> solarPanels)
        {
            SolarPanels = solarPanels;
        }
    }
}
