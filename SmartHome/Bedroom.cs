using SmartHome;

public class Bedroom : Room
{
    public Bedroom() : base("Schlafzimmer", true) { }

    public override void Update(WeatherData weatherData)
    {
        if (weatherData.Temperature < TargetTemperature)
        {
            Console.WriteLine($"[{Name}] Heating activated.");
        }

        if (HasBlinds && weatherData.Temperature > TargetTemperature && !IsOccupied)
        {
            Console.WriteLine($"[{Name}] Blinds lowered.");
        }
    }
}
