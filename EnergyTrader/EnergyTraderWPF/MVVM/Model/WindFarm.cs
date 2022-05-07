using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.Model
{
    public class WindFarm
    {
        public List<WindTurbine> WindTurbines { get; set; }
        // hardcoded values for the purpose of this prototype
        public string Location { get; } = "Nysted";
        public double Lat { get; } = 54.55;
        public double Lon { get; } = 11.71;

        public WindFarm(List<WindTurbine> windTurbines)
        {
            WindTurbines = windTurbines;
        }
    }

    
}
