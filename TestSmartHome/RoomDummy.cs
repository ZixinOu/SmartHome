using SmartHome;

namespace TestSmartHome;

public class RoomDummy : Room
{
    public RoomDummy(string name)
        : base(name, hasBlinds: false, hasAwnings: false)
    {
    }
}