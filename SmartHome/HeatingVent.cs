namespace SmartHome;

public class HeatingVent : RoomDecorator
{
    private bool _isOpen = false;

    public HeatingVent(Room room) : base(room)
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
                OpenValve();
            }
        }
        else
        {
            if (_isOpen)
            {
                _isOpen = false;
                CloseValve();
            }
        }
    }

    private void OpenValve()
    {
        Console.WriteLine($"{Name}: Heizungsventil wird geöffnet (Heizen).");
    }

    private void CloseValve()
    {
        Console.WriteLine($"{Name}: Heizungsventil wird geschlossen (kein Heizen).");
    }
}
