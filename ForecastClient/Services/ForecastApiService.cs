using ForecastClient.Helpers;
using ForecastClient.Interfaces;
using ForecastClient.Models;
using Newtonsoft.Json;
using RapidHelpers.Constants;

namespace ForecastClient.Services;

public class ForecastApiService: IForecastApiService
{
    private readonly HttpClient _httpClient;

    public ForecastApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<ForecastResponseModel> GetWeatherAsync(string city)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(ForecastHelpers.BuildUrlHelper(city)),
            Headers =
            {
                { RapidApiConstants.RapidApiRapidApiKeyHeader ,"619eab40c8msh1cc5302462f4e74p183799jsn3e860dbfbd27" },
                { RapidApiConstants.RapidApixRapidApiHostHeader, "forecast9.p.rapidapi.com" },
            },
        };

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<ForecastResponseModel>(body);
    }
}