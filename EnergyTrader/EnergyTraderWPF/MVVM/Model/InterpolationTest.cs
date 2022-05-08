using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.MVVM.Model
{
    public class InterpolationTest
    {

        List<double> wind = new List<double> { 0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0,
                                         11.0, 12.0, 13.0, 14.0, 15.0, 16.0, 17.0, 18.0, 19.0,
                                         20.0, 21.0, 22.0, 23.0, 24.0, 25.0, 26.0, 27.0, 28.0, 29.0, 30.0};

        List<double> power = new List<double> { 0.0, 0.0, 0.0, 56.0, 148.0, 288.0, 476.0, 729.0, 1055.0,
            1419.0, 1769.0, 2041.0, 2198.0, 2267.0, 2291.0, 2298.0, 2300.0, 2300.0, 2300.0, 2300.0, 2300.0,
                                           2300.0, 2300.0, 2300.0, 2300.0, 2300.0, 0.0, 0.0, 0.0, 0.0, 0.0};

        double actualWindSpeed = 3.7;

        public double GetInterpolatedPower()
        {
            double leftWind;
            double rightWind;

            double leftPower;
            double rightPower;

            double effectivePower = 0.0;

            for(int i = 0; i < wind.Count; i++)
            {
                if(actualWindSpeed>wind[i] && actualWindSpeed < wind[i + 1])
                {
                    leftWind = wind[i];
                    leftPower = power[i];

                    rightWind = wind[i + 1];
                    rightPower = power[i + 1];

                    effectivePower = Interpolate(leftWind, leftPower, rightWind, rightPower);

                }
            }

            return effectivePower;
        }


        public double Interpolate(double leftWind, double leftPower, double rightWind, double rightPower)
        {
            double effectivePower;
            // yp = y0 + ((y1-y0)/(x1-x0)) * (xp - x0);
            // yp - effectivePower
            // x0 - leftWind
            // y0 - leftPower
            // x1 - rightWind
            // y1 - rightPower
            // xp - actualWind
            effectivePower = leftPower + ((rightPower - leftPower) / (rightWind - leftWind)) * (actualWindSpeed - leftWind);
            return effectivePower;
        }

       
    }
}
