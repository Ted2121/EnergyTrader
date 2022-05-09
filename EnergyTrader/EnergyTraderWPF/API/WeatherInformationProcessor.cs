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

        //public static async Task<List<WeatherInformation>> LoadWeatherInformation()
        //{
        //    string url = $"https://api.openweathermap.org/data/2.5/onecall?lat=54.55&lon=11.71&exclude=minutely,%20daily,%20alerts,%20current&appid={ApiHelper.APIKey}";

        //    // opens a new request for the api client and awaits for response
        //    using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
        //    {
        //        if (response.IsSuccessStatusCode)
        //        {
        //            WeatherInformationResult weather = await response.Content.ReadAsAsync<WeatherInformationResult>();
        //            //weather = JsonConvert.DeserializeObject<WeatherInformation>(weather);

        //            return weather.Hourly;
        //        }
        //        // if returning data from JSON fails, we throw an exception
        //        else
        //        {
        //            throw new Exception(response.ReasonPhrase);
        //        }


        //    }
        //}

        public static async Task LoadWeatherInformation()
        {
            string url = $"https://api.openweathermap.org/data/2.5/onecall?lat=54.55&lon=11.71&exclude=minutely,%20daily,%20alerts,%20current&appid={ApiHelper.APIKey}";
            string response = await ApiHelper.ApiClient.GetStringAsync(url);
            Console.WriteLine(response);
        }

    }
}
