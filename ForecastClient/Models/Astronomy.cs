using Newtonsoft.Json;

namespace ForecastClient.Models;

public class Astronomy
{
    [JsonProperty("dawn")]
    public DateTime Dawn { get; set; }

    [JsonProperty("sunrise")]
    public DateTime Sunrise { get; set; }

    [JsonProperty("suntransit")]
    public DateTime Suntransit { get; set; }

    [JsonProperty("sunset")]
    public DateTime Sunset { get; set; }

    [JsonProperty("dusk")]
    public DateTime Dusk { get; set; }

    [JsonProperty("moonrise")]
    public DateTime? Moonrise { get; set; }

    [JsonProperty("moontransit")]
    public DateTime? Moontransit { get; set; }

    [JsonProperty("moonset")]
    public DateTime? Moonset { get; set; }

    [JsonProperty("moonphase")]
    public int Moonphase { get; set; }

    [JsonProperty("moonzodiac")]
    public int Moonzodiac { get; set; }
}