using RapidHelpers.Constants;
using VisualCrossingWeatherClient.Interfaces;
using VisualCrossingWeatherClient.Models;

namespace VisualCrossingWeatherClient.Services;

public class VisualCrossingWeatherService: IVisualCrossingWeatherService
{
    private readonly HttpClient _httpClient;

    public VisualCrossingWeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<VisualCrossingWeatherResponseModel> GetWeatherAsync(string city)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://visual-crossing-weather.p.rapidapi.com/forecast?aggregateHours=24&location={city}&contentType=json&unitGroup=us&shortColumnNames=0"),
            Headers =
            {
                { RapidApiConstants.RapidApiRapidApiKeyHeader, "619eab40c8msh1cc5302462f4e74p183799jsn3e860dbfbd27" },
                { RapidApiConstants.RapidApixRapidApiHostHeader, "visual-crossing-weather.p.rapidapi.com" },
            },
        };
        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();

        return default;
    }
}