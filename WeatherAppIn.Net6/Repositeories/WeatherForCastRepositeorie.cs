using WeatherAppIn.Net6.ApiWeather;
using WeatherAppIn.Net6.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace WeatherAppIn.Net6.Repositeories
{
    public class WeatherForCastRepositeorie : IweatherForcast
    {
        public WeatherRespoens GetWeather(string city)
        {
            string App_Id = Configruation.Values.API_KEY;
            var client = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={App_Id}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
            var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<WeatherRespoens>();
            }
            else
             return null;
        }
    }
}
