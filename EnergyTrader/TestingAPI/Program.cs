using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json;

namespace TestingAPI
{
    public class Program
    {
        static void Main(string[] args)
        {

            Rootobject root = new Rootobject();
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=54.55&lon=11.71&appid=75b38672184fbcb994200c92948dacd6";

            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync(request).Result;
            //Console.WriteLine(response.Content.ToString());

            Rootobject jsonString = JsonConvert.DeserializeObject<Rootobject>(response.Content);
            Console.WriteLine(jsonString.wind.speed);
            Console.ReadKey();
        }
    }
}
