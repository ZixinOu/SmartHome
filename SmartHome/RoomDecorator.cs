using SmartHome;

public abstract class RoomDecorator : Room
{
    protected Room innerRoom;
    protected IOutput Output;

    protected RoomDecorator(Room room, IOutput output = null)
        : base(room.Name, room.HasBlinds, room.HasAwnings)
    {
        innerRoom = room;
        Output = output ?? new ConsoleOutput();
    }

    public abstract void Operate(
        double externalTemperature,
        double roomTemperature,
        double windSpeed,
        bool isRaining,
        bool peopleInRoom);
}