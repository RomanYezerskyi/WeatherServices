using Newtonsoft.Json;

namespace ForecastClient.Models;

public class ForecastResponseModel
{
    [JsonProperty("location")]
    public Location Location { get; set; }

    [JsonProperty("forecast")]
    public Forecast Forecast { get; set; }
}