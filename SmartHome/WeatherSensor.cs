namespace SmartHome;

public class WeatherSensor
{
    private readonly Random random = new();
    private int lastTemperature;
    private int lastWindSpeed;
    private bool isRaining = false;
    
    public WeatherSensor()
    {
        lastTemperature = random.Next(-5, 26);
    }

    
    public WeatherData GenerateWeather()
    {
        const int maxTempStep = 2;
        const int maxWindStep = 7;
        
        int tempDelta = random.Next(-maxTempStep, maxTempStep + 1);
        if (random.NextDouble() < 0.02)
            tempDelta += random.Next(-5, 6);

        int temp = Math.Clamp(lastTemperature + tempDelta, -10, 35);
        lastTemperature = temp;
        
        int windDelta = random.Next(-maxWindStep, maxWindStep + 1);
        int windSpeed = Math.Clamp(lastWindSpeed + windDelta, 0, 70);
        lastWindSpeed = windSpeed;
        
        if (random.NextDouble() < 0.05)
            isRaining = !isRaining;

        return new WeatherData
        {
            Temperature = temp,
            WindSpeed = windSpeed,
            IsRaining = isRaining
        };
    }
}