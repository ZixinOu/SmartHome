using SmartHome;

class WinterGarden : Room
{
    public WinterGarden() : base("Wintergarten", true, true) { }

    public override void Update(WeatherData weatherData)
    {
        if (weatherData.Temperature < TargetTemperature)
        {
            Console.WriteLine($"[{Name}] Heating activated.");
        }

        if (HasBlinds && weatherData.Temperature > TargetTemperature && weatherData.WindSpeed <= 30)
        {
            Console.WriteLine($"[{Name}] Awning extended.");
        }

        if (HasBlinds && weatherData.Temperature > TargetTemperature && !IsOccupied)
        {
            Console.WriteLine($"[{Name}] Blinds lowered.");
        }
    }
}
