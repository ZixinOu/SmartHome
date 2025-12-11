
using SmartHome;

public class LivingRoom : Room
{
    public LivingRoom() : base("Wohnzimmer", true) { }

    public override void Update(WeatherData weatherData)
    {
        if (weatherData.Temperature < TargetTemperature)
        {
            Console.WriteLine($"[{Name}] Heating activated.");
        }

        if (HasBlinds && weatherData.Temperature > TargetTemperature)
        {
            Console.WriteLine($"[{Name}] Blinds lowered.");
        }
    }
}