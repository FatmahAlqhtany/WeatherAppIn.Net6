using WeatherAppIn.Net6.ApiWeather;
namespace WeatherAppIn.Net6.Repositeories
{
    public interface IweatherForcast
    {
        WeatherRespoens GetWeather(string city);
    }
}
