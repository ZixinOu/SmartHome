namespace SmartHome;

public class WeatherSensor
{
    private readonly Random random = new();
    private int lastTemperature;
    
    public WeatherSensor()
    {
        lastTemperature = random.Next(-5, 26);
    }

    public WeatherData GenerateWeather()
    {
        const int maxStep = 3;
        int delta = random.Next(-maxStep, maxStep + 1);

        // selten größere Sprünge (z.B. Wetterfront)
        if (random.NextDouble() < 0.02)
            delta += random.Next(-5, 6);

        int temp = Math.Clamp(lastTemperature + delta, -10, 35);
        lastTemperature = temp;

        return new WeatherData
        {
            Temperature = temp,
            WindSpeed = random.Next(0, 50),
            IsRaining = random.Next(0, 2) == 1
        };
    }
}