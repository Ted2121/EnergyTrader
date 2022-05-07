using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EnergyTraderWPF.API
{
    public static class ApiHelper
    {
        public static string APIKey { get; } = "75b38672184fbcb994200c92948dacd6";
        // we only allow 1 per application
        public static HttpClient ApiClient { get; set; }
        
       
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            // base address
            // continue with weather?lat&lon&appid
            ApiClient.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

    

    
    }
}
