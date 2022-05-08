using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.API
{
    public class Root
    {
        public class hourly
        {
            public double Wind_Speed { get; set; }
        }

        public List<hourly> Hourly { get; set; }
    }
}
