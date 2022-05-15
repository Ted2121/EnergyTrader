using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApi
{
    public class WeatherInformationWebService
    {
        public static double GetWindInformation()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=54.55&lon=11.71&appid=75b38672184fbcb994200c92948dacd6";
            Rootobject jsonString = null;

            try
            {
                var client = new RestClient(url);

                var request = new RestRequest();
                var response = client.GetAsync(request).Result;

                jsonString = JsonConvert.DeserializeObject<Rootobject>(response.Content);
            }
            catch (Exception e)
            {
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return jsonString.wind.speed;
        }

        public static (int, int) GetSunInformation()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=56.38&lon=8.49&appid=75b38672184fbcb994200c92948dacd6";
            Rootobject jsonString = null;
            try
            { 
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;

            jsonString = JsonConvert.DeserializeObject<Rootobject>(response.Content);

            }catch (Exception e)
            {
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return (jsonString.sys.sunrise, jsonString.sys.sunset);
        }

    }
}
