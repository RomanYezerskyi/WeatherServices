using Newtonsoft.Json;

namespace VisualCrossingWeatherClient.Models;

public class Weather
{
    [JsonProperty("stationContributions")]
    public object StationContributions { get; set; }

    [JsonProperty("values")]
    public List<Value> Values { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("address")]
    public string Address { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("index")]
    public int Index { get; set; }

    [JsonProperty("latitude")]
    public double Latitude { get; set; }

    [JsonProperty("longitude")]
    public double Longitude { get; set; }

    [JsonProperty("distance")]
    public double Distance { get; set; }

    [JsonProperty("time")]
    public double Time { get; set; }

    [JsonProperty("tz")]
    public string Tz { get; set; }

    [JsonProperty("currentConditions")]
    public object CurrentConditions { get; set; }

    [JsonProperty("alerts")]
    public object Alerts { get; set; }
}