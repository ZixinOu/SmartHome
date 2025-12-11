
using SmartHome;

public class Kitchen : Room
{
    public Kitchen() : base("Küche", true) { }

    public override void Update(WeatherData weatherData)
    {
        if (weatherData.Temperature < TargetTemperature)
        {
            Console.WriteLine($"[{Name}] Heating activated.");
        }
    }
}
