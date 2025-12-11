namespace SmartHome;

public class Jalousiencontroler : RoomDecorator
{
    private bool _isLowered = false;

    public Jalousiencontroler(Room room) : base(room)
    {
    }

    public override void Operate(double externalTemperature, double roomTemperature, double windSpeed, bool isRaining, bool peopleInRoom)
    {
        if (externalTemperature > roomTemperature && !peopleInRoom)
        {
            if (!_isLowered)
            {
                _isLowered = true;
                LowerBlinds();
            }
        }
        else
        {
            if (_isLowered)
            {
                _isLowered = false;
                RaiseBlinds();
            }
        }
    }

    private void LowerBlinds()
    {
        Console.WriteLine($"{Name}: Jalousie wird runtergefahren.");
    }

    private void RaiseBlinds()
    {
        Console.WriteLine($"{Name}: Jalousie wird hochgefahren.");
    }
}
