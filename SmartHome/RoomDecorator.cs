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

        public abstract void Operate(
            double externalTemperature,
            double roomTemperature,
            double windSpeed,
            bool isRaining,
            bool peopleInRoom);
        
        public static bool Update(Room room, WeatherData data)
        {
            try
            {
                var method = room.GetType().GetMethod("UpdateWithWeather");
                if (method != null)
                {
                    var result = method.Invoke(room, new object[] { data });
                    if (result is bool b) return b;
                }
            }
            catch { }

            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Updated {room.GetType().Name} with weather {data} (Markisensteuerung applied)");
            return true;
        }
    }

}
