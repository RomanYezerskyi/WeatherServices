using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using RapidHelpers.Constants;
using WeatherAPIClient.Interfaces;
using WeatherAPIClient.Services;
using WeatherServicesCore.General.Extensions;

namespace WeatherAPIClient.Extensions;

public static class WeatherApiServiceDependencyInjection
{
    public static IServiceCollection AddWeatherApiService(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient<IWeatherAPIService, WeatherAPIService>((serviceProvider, httpClient) =>
        {
            httpClient.DefaultRequestHeaders
                .Add(RapidApiConstants.RapidApiRapidApiKeyHeader ,"619eab40c8msh1cc5302462f4e74p183799jsn3e860dbfbd27");
            httpClient.DefaultRequestHeaders
                .Add(RapidApiConstants.RapidApixRapidApiHostHeader, "weatherapi-com.p.rapidapi.com");
            
            httpClient.BaseAddress = new Uri("https://weatherapi-com.p.rapidapi.com");
        }).AddHttpClientRetryPolicy();
        
        return serviceCollection;
    }
}