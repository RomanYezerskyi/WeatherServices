using Newtonsoft.Json;

namespace VisualCrossingWeatherClient.Models;

public class Locations
{
    [JsonProperty("Washington,DC,USA")]
    public Weather WashingtonDCUSA { get; set; }
}