using SmartHome;

namespace SmartHome.Tests;

public class RoomDummy : Room
{
    public RoomDummy(string name)
        : base(name, hasBlinds: false, hasAwnings: false)
    {
    }
}