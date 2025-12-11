namespace SmartHome;

public class WeatherSensor
{
    private Random random = new Random();

    public WeatherData GenerateWeather()
    {
        return new WeatherData
        {
            Temperature = random.Next(-10, 36),
            WindSpeed = random.Next(0, 50),
            IsRaining = random.Next(0, 2) == 1
        };
    }
}