using System;

namespace SmartHome;

public class HeatingVent : RoomDecorator
{
    private bool _isOpen = false;

    public HeatingVent(Room room, IOutput output = null)
        : base(room, output)
    {
        if (room.Name == "Wintergarten" || room.Name == "Garage")
            throw new InvalidOperationException("Heizungsventile sind in diesem Raum nicht erlaubt.");
    }

    public override void Operate(double externalTemperature, double roomTemperature, double windSpeed, bool isRaining, bool peopleInRoom)
    {
        if (externalTemperature < roomTemperature)
        {
            if (!_isOpen)
            {
                _isOpen = true;
                Output.Write($"{Name}: Heizungsventil wird geöffnet (Heizen).");
            }
        }
        else
        {
            if (_isOpen)
            {
                _isOpen = false;
                Output.Write($"{Name}: Heizungsventil wird geschlossen (kein Heizen).");
            }
        }
    }
}