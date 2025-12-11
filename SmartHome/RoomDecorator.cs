using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public abstract class RoomDecorator : Room
    {
        protected Room innerRoom;

        protected RoomDecorator(Room room)
            : base(room.Name, room.HasBlinds, room.HasAwnings)
        {
            innerRoom = room;
        }

        public override void Update(WeatherData weatherData)
        {
            innerRoom.Update(weatherData);
        }

        public abstract void Operate(
            double externalTemperature,
            double roomTemperature,
            double windSpeed,
            bool isRaining,
            bool peopleInRoom);
    }

}
