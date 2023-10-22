using ForecastClient.Models;

namespace ForecastClient.Interfaces;

public interface IForecastApiService
{
    Task<ForecastResponseModel> GetWeatherAsync(string city);
}