using Newtonsoft.Json;

namespace ForecastClient.Models;

public class Item
{
    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("dateWithTimezone")]
    public DateTime DateWithTimezone { get; set; }

    [JsonProperty("freshSnow")]
    public int? FreshSnow { get; set; }

    [JsonProperty("snowHeight")]
    public object SnowHeight { get; set; }

    [JsonProperty("weather")]
    public Weather Weather { get; set; }

    [JsonProperty("prec")]
    public Prec Prec { get; set; }

    [JsonProperty("sunHours")]
    public int SunHours { get; set; }

    [JsonProperty("rainHours")]
    public object RainHours { get; set; }

    [JsonProperty("temperature")]
    public Temperature Temperature { get; set; }

    [JsonProperty("wind")]
    public Wind Wind { get; set; }

    [JsonProperty("windchill")]
    public Windchill Windchill { get; set; }

    [JsonProperty("snowLine")]
    public SnowLine SnowLine { get; set; }

    [JsonProperty("astronomy")]
    public Astronomy Astronomy { get; set; }
}