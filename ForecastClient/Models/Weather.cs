using Newtonsoft.Json;

namespace ForecastClient.Models;

public class Weather
{
    [JsonProperty("state")]
    public int State { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("icon")]
    public string Icon { get; set; }
}