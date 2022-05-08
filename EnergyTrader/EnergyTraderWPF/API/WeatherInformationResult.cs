using EnergyTraderWPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.API
{
    public class WeatherInformationResult
    {
        public List<WeatherInformation> Hourly { get; set; }
    }
}
