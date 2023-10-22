using Newtonsoft.Json;

namespace WeatherAPIClient.Models;

public class WeatherResponseModel
{
    [JsonProperty("location")]
    public Location Location { get; set; }

    [JsonProperty("forecast")]
    public Forecast Forecast { get; set; }
}
