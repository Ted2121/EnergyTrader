using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System.Net;


namespace WeatherInformationAPI
{
    public class WeatherInformationApiClient
    {

        static string apiKey = "75b38672184fbcb994200c92948dacd6";

        public static double GetWindInformation()
        {
            Rootobject root = new Rootobject();
            string url = $"https://api.openweathermap.org/data/2.5/weather?lat=54.55&lon=11.71&appid={apiKey}";

            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;
            

            Rootobject jsonString = JsonConvert.DeserializeObject<Rootobject>(response.Content);
            return jsonString.wind.speed;
        }

        public static async Task<Rootobject> GetSunInformationAsync()
        {
            
            Rootobject root = new Rootobject();
            string url = $"https://api.openweathermap.org/data/2.5/weather?lat=56.38&lon=8.49&appid=E:{apiKey}";

            var client = new RestClient(url);
            var request = new RestRequest();
            var response = await client.GetAsync(request);

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error getting response. Message was {response.Content}");
            }
            return response;
        }


        public static DateTime convertSecondsToDateTime(int sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }


    }
}
