
using SmartHome;

public class Bathroom : Room
{
    public Bathroom() : base("Bad/WC", false) { }

    public override void Update(WeatherData weatherData)
    {
        if (weatherData.Temperature < TargetTemperature)
        {
            Console.WriteLine($"[{Name}] Heating activated.");
        }
    }
}