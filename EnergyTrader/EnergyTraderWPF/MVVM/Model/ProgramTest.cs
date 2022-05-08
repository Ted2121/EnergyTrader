using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.Model
{
    public class ProgramTest
    {
        static void Main(string[] args)
        {
            InterpolationTest test = new InterpolationTest();

            test.GetInterpolatedPower();
        }
    }
}
