using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EnergyTraderWPF.MVVM.Model;




namespace EnergyTraderWPF.API
{
    public class WeatherInformationProcessor
    {
        public static async Task<WeatherInformation.Root> LoadWeatherInformation(double lat, double lon)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={ApiHelper.APIKey}";

            // opens a new request for the api client and awaits for response
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url)){
                if (response.IsSuccessStatusCode)
                {
                    WeatherInformation.Root weather = await response.Content.ReadAsAsync<WeatherInformation.Root>();
                    
                    return weather;
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
