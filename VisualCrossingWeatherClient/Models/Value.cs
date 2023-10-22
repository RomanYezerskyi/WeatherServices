using Newtonsoft.Json;

namespace VisualCrossingWeatherClient.Models;

public class Value
{
    [JsonProperty("wdir")]
    public double Wdir { get; set; }

    [JsonProperty("temp")]
    public double Temp { get; set; }

    [JsonProperty("maxt")]
    public double Maxt { get; set; }

    [JsonProperty("visibility")]
    public double Visibility { get; set; }

    [JsonProperty("wspd")]
    public double Wspd { get; set; }

    [JsonProperty("datetimeStr")]
    public DateTime DatetimeStr { get; set; }

    [JsonProperty("solarenergy")]
    public double Solarenergy { get; set; }

    [JsonProperty("heatindex")]
    public object Heatindex { get; set; }

    [JsonProperty("cloudcover")]
    public double Cloudcover { get; set; }

    [JsonProperty("mint")]
    public double Mint { get; set; }

    [JsonProperty("datetime")]
    public object Datetime { get; set; }

    [JsonProperty("precip")]
    public double Precip { get; set; }

    [JsonProperty("solarradiation")]
    public double Solarradiation { get; set; }

    [JsonProperty("weathertype")]
    public string Weathertype { get; set; }

    [JsonProperty("snowdepth")]
    public double Snowdepth { get; set; }

    [JsonProperty("sealevelpressure")]
    public double Sealevelpressure { get; set; }

    [JsonProperty("snow")]
    public double Snow { get; set; }

    [JsonProperty("dew")]
    public double Dew { get; set; }

    [JsonProperty("humidity")]
    public double Humidity { get; set; }

    [JsonProperty("precipcover")]
    public double Precipcover { get; set; }

    [JsonProperty("wgust")]
    public double? Wgust { get; set; }

    [JsonProperty("conditions")]
    public string Conditions { get; set; }

    [JsonProperty("windchill")]
    public double? Windchill { get; set; }

    [JsonProperty("info")]
    public object Info { get; set; }
}