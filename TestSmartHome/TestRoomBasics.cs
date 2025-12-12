using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHome;

namespace TestSmartHome
{
    [TestClass]
    public class TestRoomBasics
    {
        [TestMethod]
        public void Rooms_HaveCorrectBaseValues()
        {
            Room[] rooms =
            {
                new Bathroom(),
                new Bedroom(),
                new Kitchen(),
                new LivingRoom(),
                new Garage(),
                new WinterGarden()
            };

            foreach (var room in rooms)
            {
                Assert.IsNotNull(room.Name);
                Assert.AreEqual(22, room.TargetTemperature);
                room.TargetTemperature = 25;
                Assert.AreEqual(25, room.TargetTemperature);
            }
        }
    }
}