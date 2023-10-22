using System.Net.Http.Json;
using Newtonsoft.Json;
using RapidHelpers.Constants;
using WeatherAPIClient.Helpers;
using WeatherAPIClient.Interfaces;
using WeatherAPIClient.Models;

namespace WeatherAPIClient.Services;

public class WeatherAPIService: IWeatherAPIService
{
    private readonly HttpClient _httpClient;
    
    public WeatherAPIService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<WeatherResponseModel> GetWeatherAsync(string city, DateTimeOffset startDate, DateTimeOffset endDate)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(WeatherAPIHelpers.BuildUrlHelper(city, startDate, endDate)),
            Headers =
            {
                { RapidApiConstants.RapidApiRapidApiKeyHeader ,"619eab40c8msh1cc5302462f4e74p183799jsn3e860dbfbd27" },
                { RapidApiConstants.RapidApixRapidApiHostHeader, "weatherapi-com.p.rapidapi.com" },
            },
        };

        var response = await _httpClient
            .GetFromJsonAsync<WeatherResponseModel>(WeatherAPIHelpers.BuildUrlHelper(city, startDate, endDate));

        return response;
    }
}