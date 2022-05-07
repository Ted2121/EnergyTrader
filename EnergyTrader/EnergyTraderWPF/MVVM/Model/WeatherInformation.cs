using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.Model
{
    public class WeatherInformation
    {
        public class Coord
        {
            public double Lon { get; set; }
            public double Lat { get; set; }

        }

        public class Weather
        {
            public string Main { get; set; }
            public string Description { get; set; }
            public string Icon { get; set; }

        }


        public class Wind
        {
            public double Speed { get; set; }

        }


        public class Sys
        {
            public long Sunrise { get; set; }
            public long Sunset { get; set; }

        }

        public class Root
        {
            public Coord coord { get; set; }
            public List<Weather> weather { get; set; }
            public Wind wind { get; set; } 
            public Sys sys { get; set; }

        }
    }
}
