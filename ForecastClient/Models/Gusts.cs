using Newtonsoft.Json;

namespace ForecastClient.Models;

public class Gusts
{
    [JsonProperty("value")]
    public int? Value { get; set; }

    [JsonProperty("text")]
    public object Text { get; set; }
}