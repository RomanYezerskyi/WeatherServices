using WeatherAPIClient.Models;

namespace WeatherAPIClient.Interfaces;

public interface IWeatherAPIService
{
    Task<WeatherResponseModel> GetWeatherAsync(string city, DateTimeOffset startDate, DateTimeOffset endDate);
}