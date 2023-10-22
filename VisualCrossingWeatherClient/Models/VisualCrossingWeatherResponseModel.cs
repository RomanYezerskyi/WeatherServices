using Newtonsoft.Json;

namespace VisualCrossingWeatherClient.Models;

public class VisualCrossingWeatherResponseModel
{
    [JsonProperty("locations")]
    public Locations Locations { get; set; }
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);