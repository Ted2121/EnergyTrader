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

        //public static async Task<Root> LoadWeatherInformationAsync()
        //{
        //    string url = $"https://api.openweathermap.org/data/2.5/weather?lat=54.55&lon=11.71&appid={ApiHelper.APIKey}";

        //    // opens a new request for the api client and awaits for response
        //    using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
        //    {
        //        if (response.IsSuccessStatusCode)
        //        {
        //            Root root = await response.Content.ReadAsAsync<Root>();


        //            return root;
        //        }
        //        // if returning data from JSON fails, we throw an exception
        //        else
        //        {
        //            throw new Exception(response.ReasonPhrase);
        //        }


        //    }
        //}

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

    

    }
}
