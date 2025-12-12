namespace SmartHome;

using System;

public class Markisensteuerung : RoomDecorator
{
    public Markisensteuerung(Room room, IOutput output = null)
        : base(room, output)
    {
        if (room.Name != "Wintergarten")
            throw new InvalidOperationException("Markisensteuerungen sind nur im Wintergarten erlaubt.");

        HasAwnings = true;
    }

    public override void Operate(double externalTemperature, double roomTemperature, double windSpeed, bool isRaining, bool peopleInRoom)
    {
        if (externalTemperature > roomTemperature && windSpeed <= 30 && !isRaining)
        {
            Output.Write($"{Name}: Markise wird ausgefahren.");
        }
        else
        {
            Output.Write($"{Name}: Markise wird eingefahren.");
        }
    }
}
