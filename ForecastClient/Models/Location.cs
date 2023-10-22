using Newtonsoft.Json;

namespace ForecastClient.Models;

public class Location
{
    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    [JsonProperty("coordinates")]
    public Coordinates Coordinates { get; set; }
}