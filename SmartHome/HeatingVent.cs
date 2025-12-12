using System;

namespace SmartHome;

public class HeatingVent : RoomDecorator
{
    private bool _isHeating;

    public HeatingVent(Room room, IOutput output)
        : base(room, output)
    
    {
        if (room.Name == "Wintergarten" || room.Name == "Garage")
            throw new InvalidOperationException("Heizungsventile sind in diesem Raum nicht erlaubt.");
    }

    public override void Operate(double externalTemperature, double roomTemperature, double windSpeed, bool isRaining, bool peopleInRoom)
    {
        if (externalTemperature < roomTemperature)
        {
            if (!_isHeating)
            {
                _isHeating = true;
                Output.Write($"{Name}: Heizungsventil wird geöffnet (Heizen).");
            }
        }
        else
        {
            if (_isHeating)
            {
                _isHeating = false;
                Output.Write($"{Name}: Heizungsventil wird geschlossen (kein Heizen).");
            }
        }
    }
}