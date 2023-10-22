namespace WeatherAPIClient.Helpers;

public static class WeatherAPIHelpers
{
    public static string BuildUrlHelper(string city, DateTimeOffset startDate, DateTimeOffset endDate)
    {
        return $"/history.json?q={city}&dt={startDate:YYYY-MM-DD}&lang=en&end_dt={endDate:YYYY-MM-DD}";
    }
}