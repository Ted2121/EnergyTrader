
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EnergyTraderWPF.MVVM.Model
{
    public class WindFarmModel
    {
        public string Name { get; set; }
        public int NumberOfTurbines { get; set; }
        public int TurbineCapacity { get; set; }
        public int TotalNominalPower { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double EffectivePower { get; set; }
        public double TotalEffectivePower { get; set; }
        public double ExpectedLoadRate { get; set; }
        public double ExpectedProduction { get; set; }
       
        List<double> windCurve = new List<double> { 0.0, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0,
                                         11.0, 12.0, 13.0, 14.0, 15.0, 16.0, 17.0, 18.0, 19.0,
                                         20.0, 21.0, 22.0, 23.0, 24.0, 25.0, 26.0, 27.0, 28.0, 29.0, 30.0};

        List<double> powerCurve = new List<double> { 0.0, 0.0, 0.0, 56.0, 148.0, 288.0, 476.0, 729.0, 1055.0,
            1419.0, 1769.0, 2041.0, 2198.0, 2267.0, 2291.0, 2298.0, 2300.0, 2300.0, 2300.0, 2300.0, 2300.0,
                                           2300.0, 2300.0, 2300.0, 2300.0, 2300.0, 0.0, 0.0, 0.0, 0.0, 0.0};

        public List<double> WindCurve { get;}
        public List<double> PowerCurve { get; }


        public WindFarmModel(string name,
            int numberOfTurbines,
            int turbineCapacity,
            double lat,
            double lon)
        {
            
            Name = name;
            NumberOfTurbines = numberOfTurbines;
            TurbineCapacity = turbineCapacity;

            Lat = lat;
            Lon = lon;
        }
        private double Interpolate(double actualWindSpeed, double leftWind, double leftPower, double rightWind, double rightPower)
        {
            double effectivePower;

            effectivePower = leftPower + ((rightPower - leftPower) / (rightWind - leftWind)) * (actualWindSpeed - leftWind);
            return Math.Round(effectivePower, 2);
        }
        public double GetInterpolatedPower(double actualWindSpeed)
        {
            double leftWind;
            double rightWind;

            double leftPower;
            double rightPower;

            double effectivePower = 0.0;

            for (int i = 0; i < windCurve.Count; i++)
            {
                if (actualWindSpeed > windCurve[i] && actualWindSpeed < windCurve[i + 1])
                {
                    leftWind = windCurve[i];
                    leftPower = powerCurve[i];

                    rightWind = windCurve[i + 1];
                    rightPower = powerCurve[i + 1];

                    effectivePower = Interpolate(actualWindSpeed, leftWind, leftPower, rightWind, rightPower);

                }else if(actualWindSpeed == windCurve[i])
                {
                    effectivePower = windCurve[i];
                }
            }

            return effectivePower;
        }
        public int CalculateTotalNominalPower()
        {
            return TurbineCapacity * NumberOfTurbines;
        }

        public double CalculateTotalEffectivePower()
        {
            return EffectivePower * NumberOfTurbines;
        }

        public double CalculateExpectedProduction()
        {
            return TotalEffectivePower * 24;
        }


        public double CalculateExpectedLoadRate(double actualWindSpeed)
        {
            ExpectedLoadRate = (100 * GetInterpolatedPower(actualWindSpeed)) / TurbineCapacity;
            return ExpectedLoadRate;
        }

    }
}
