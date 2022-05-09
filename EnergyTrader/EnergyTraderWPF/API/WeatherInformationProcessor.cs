using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EnergyTraderWPF.MVVM.Model;
using Newtonsoft.Json;
using RestSharp;

namespace EnergyTraderWPF.API
{
    public class WeatherInformationProcessor
    {

  

        public static double GetWindInformation()
        {
            Rootobject root = new Rootobject();
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=54.55&lon=11.71&appid=75b38672184fbcb994200c92948dacd6";

            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;
            //Console.WriteLine(response.Content.ToString());

            Rootobject jsonString = JsonConvert.DeserializeObject<Rootobject>(response.Content);
            return jsonString.wind.speed;
        }

        public (int, int) GetSunInformation()
        {
            Rootobject root = new Rootobject();
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=56.38&lon=8.49&appid=75b38672184fbcb994200c92948dacd6";

            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;
            //Console.WriteLine(response.Content.ToString());

            Rootobject jsonString = JsonConvert.DeserializeObject<Rootobject>(response.Content);
            return (jsonString.sys.sunrise, jsonString.sys.sunset);
        }


        public DateTime convertSecondsToDateTime(int sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }


    }
}
