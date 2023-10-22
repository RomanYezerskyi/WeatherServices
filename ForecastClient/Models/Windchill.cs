using Newtonsoft.Json;

namespace ForecastClient.Models;

public class Windchill
{
    [JsonProperty("min")]
    public int Min { get; set; }

    [JsonProperty("max")]
    public int Max { get; set; }

    [JsonProperty("avg")]
    public object Avg { get; set; }
}