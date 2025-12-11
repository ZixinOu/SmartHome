using SmartHome;

namespace TestSmartHome;

public class TestRoom : Room
{
    public TestRoom(string name)
        : base(name, hasBlinds: false, hasAwnings: false)
    {
    }

    public override void Update(WeatherData weatherData)
    {
    }
}