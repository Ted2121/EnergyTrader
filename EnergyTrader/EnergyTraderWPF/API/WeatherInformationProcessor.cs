using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EnergyTraderWPF.MVVM.Model;
using Newtonsoft.Json;

namespace EnergyTraderWPF.API
{
    public class WeatherInformationProcessor
    {

        public static async Task<Root> LoadWeatherInformationAsync()
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?lat=54.55&lon=11.71&appid={ApiHelper.APIKey}";

            // opens a new request for the api client and awaits for response
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Root root = await response.Content.ReadAsAsync<Root>();


                    return root;
                }
                // if returning data from JSON fails, we throw an exception
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }


            }
        }

    

    }
}
