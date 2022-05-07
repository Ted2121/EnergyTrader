using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.Model
{
    public class WindFarm
    {
        public string Name{ get; set; }
        public int NumberOfTurbines { get; set; }
        public int TurbineCapacity { get; set; }
        public int TotalNominalPower { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double ExpectedLoadRate { get; set; }
        public double ExpectedProduction { get; set; }
        public WindFarm()
        {
            
        }
    }

    
}
