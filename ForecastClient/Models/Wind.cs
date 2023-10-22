using Newtonsoft.Json;

namespace ForecastClient.Models;

public class Wind
{
    [JsonProperty("unit")]
    public string Unit { get; set; }

    [JsonProperty("direction")]
    public string Direction { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("avg")]
    public object Avg { get; set; }

    [JsonProperty("min")]
    public int Min { get; set; }

    [JsonProperty("max")]
    public int Max { get; set; }

    [JsonProperty("gusts")]
    public Gusts Gusts { get; set; }

    [JsonProperty("significationWind")]
    public bool SignificationWind { get; set; }
}