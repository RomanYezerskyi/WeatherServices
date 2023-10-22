using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;
using Polly.Extensions.Http;

namespace WeatherServicesCore.General.Extensions;

public static class PollyExtensions
{
    public static IHttpClientBuilder AddHttpClientRetryPolicy(this IHttpClientBuilder httpClientBuilder)
    {
        httpClientBuilder.AddPolicyHandler((provider, message) =>
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .WaitAndRetryAsync(
                    5,
                    sleepDuration => TimeSpan.FromSeconds(5),
                    (result, timeSpan, retryCount, context) =>
                    {
                        if(provider.GetService<ILogger>() is not { } logger) return;
                        
                        logger.LogWarning(
                            "HttpClient request attempt {@Attempt} failed with message: {@Message}, next attempt in {@Seconds} s.",
                            retryCount, result.Exception.Message, timeSpan.TotalSeconds);
                        
                    });
        });

        return httpClientBuilder;
    } 
}