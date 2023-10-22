using VisualCrossingWeatherClient.Models;

namespace VisualCrossingWeatherClient.Interfaces;

public interface IVisualCrossingWeatherService
{
    Task<VisualCrossingWeatherResponseModel> GetWeatherAsync(string city);
}