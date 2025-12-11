namespace SmartHome;

public class WeatherData
{
    public int Temperature { get; set; }
    public int WindSpeed { get; set; }
    public bool IsRaining { get; set; }

    public override string ToString()
    {
        return $"Temperature: {Temperature}°C, WindSpeed: {WindSpeed} km/h, Raining: {IsRaining}";
    }
}
