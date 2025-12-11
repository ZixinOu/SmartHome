using SmartHome;
public abstract class Room
{
    public string Name { get; protected set; }
    public bool HasBlinds { get; protected set; }
    public bool HasAwnings { get; protected set; }
    public int TargetTemperature { get; set; } = 22;
    public bool IsOccupied { get; protected set; }

    protected Room(string name, bool hasBlinds, bool hasAwnings = false)
    {
        Name = name;
        HasBlinds = hasBlinds;
        HasAwnings = hasAwnings;
    }

    public abstract void Update(WeatherData weatherData);
}