using Microsoft.AspNetCore.Mvc;
using WeatherAppIn.Net6.ApiWeather;
using WeatherAppIn.Net6.Models;
using WeatherAppIn.Net6.Repositeories;

namespace WeatherAppIn.Net6.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IweatherForcast _weather;

        public WeatherController(IweatherForcast weather)
        {
            _weather = weather;
        }
        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City",
                   "Weather",
                    new { city = model.CityName});
            }
            return View();
        }
        [HttpGet]
        public IActionResult City(string city)
        {
            WeatherRespoens  weatherRespones = _weather.GetWeather(city);
            City viewModel = new City();
            if (weatherRespones !=null)
            {
                viewModel.Name = weatherRespones.Name;
                viewModel.Temperature = weatherRespones.Main.Temp;
                viewModel.Humidity = weatherRespones.Main.Humidity;
                viewModel.Pressure = weatherRespones.Main.Pressure;
                viewModel.Weather = weatherRespones.Weather[0].Main;
                viewModel.Wind = weatherRespones.wind.Speed;

            }
            return View(viewModel);
        }
    }
}
