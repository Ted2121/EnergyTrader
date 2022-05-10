using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApi
{
    public class WeatherInformationWebService
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

        public static (int, int) GetSunInformation()
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


        
    }
}
