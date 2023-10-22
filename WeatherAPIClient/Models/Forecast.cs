using Newtonsoft.Json;

namespace WeatherAPIClient.Models;

public class Forecast
{
    [JsonProperty("forecastday")]
    public List<ForecastDay> Forecastday { get; set; }
}