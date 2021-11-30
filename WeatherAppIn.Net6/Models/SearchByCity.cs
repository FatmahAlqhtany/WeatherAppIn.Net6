using System.ComponentModel.DataAnnotations;

namespace WeatherAppIn.Net6.Models
{
    public class SearchByCity
    {
        [Display(Name =("City Name"))]
        [Required(ErrorMessage =("City Name is empty"))]
        [StringLength(30,MinimumLength =2,ErrorMessage =("Must enter a city between 30 and 2 "))]
        public string CityName { get; set; }

    }
}
