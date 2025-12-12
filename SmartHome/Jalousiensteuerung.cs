using System;

namespace SmartHome;

public class Jalousiencontroler : RoomDecorator
{
    private bool _isLowered = false;

    public Jalousiencontroler(Room room, IOutput output = null)
        : base(room, output)
    {
        if (room.Name == "Bad/WC" || room.Name == "Garage")
            throw new InvalidOperationException("Jalousiensteuerungen sind in diesem Raum nicht erlaubt.");
    }

    public override void Operate(double externalTemperature, double roomTemperature, double windSpeed, bool isRaining, bool peopleInRoom)
    {
        if (externalTemperature > roomTemperature && !peopleInRoom)
        {
            if (!_isLowered)
            {
                _isLowered = true;
                Output.Write($"{Name}: Jalousie wird runtergefahren.");
            }
        }
        else
        {
            if (_isLowered)
            {
                _isLowered = false;
                Output.Write($"{Name}: Jalousie wird hochgefahren.");
            }
        }
    }
}