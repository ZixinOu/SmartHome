using SmartHome;
public abstract class Room
{
    public string Name { get; set; }
    public bool HasBlinds { get; set; }
    public bool HasAwnings { get; set; }
    public int TargetTemperature { get; set; } = 22;

    protected Room(string name, bool hasBlinds = false, bool hasAwnings = false)
    {
        Name = name;
        HasBlinds = hasBlinds;
        HasAwnings = hasAwnings;
    }
}