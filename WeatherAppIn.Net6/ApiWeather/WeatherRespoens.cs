namespace WeatherAppIn.Net6.ApiWeather
{
    public class WeatherRespoens
    {
        public coord Coord { get; set; }
        public List<weather> Weather { get; set; }
        public string Base { get; set; }
        public main Main { get; set; }
        public int Visability { get; set; }
        public wwwroot.wind wind { get; set; }

        public clouds Clouds { get; set; }
        public int Dt { get; set; }
        public sys Sys { get; set; }   
        public int Timezone { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
         public int Cod { get; set; }

    }
}
