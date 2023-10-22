namespace ForecastClient.Helpers;

public static class ForecastHelpers
{
    public static string BuildUrlHelper(string city)
    {
        return $"https://forecast9.p.rapidapi.com/rapidapi/forecast/{city}/summary/";
    }
}