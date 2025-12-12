using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmartHome.Tests
{
    [TestClass]
    public class TestRooms
    {
        [TestMethod]
        public void TestBathroomProperties()
        {
            var room = new Bathroom();
            Assert.AreEqual("Bad/WC", room.Name);
            Assert.IsFalse(room.HasBlinds);
            Assert.IsFalse(room.HasAwnings);
        }

        [TestMethod]
        public void TestBedroomProperties()
        {
            var room = new Bedroom();
            Assert.AreEqual("Schlafzimmer", room.Name);
            Assert.IsFalse(room.HasBlinds);
            Assert.IsFalse(room.HasAwnings);
        }

        [TestMethod]
        public void TestKitchenProperties()
        {
            var room = new Kitchen();
            Assert.AreEqual("Küche", room.Name);
            Assert.IsFalse(room.HasBlinds);
            Assert.IsFalse(room.HasAwnings);
        }

        [TestMethod]
        public void TestLivingRoomProperties()
        {
            var room = new LivingRoom();
            Assert.AreEqual("Wohnzimmer", room.Name);
            Assert.IsFalse(room.HasBlinds);
            Assert.IsFalse(room.HasAwnings);
        }

        [TestMethod]
        public void TestGarageProperties()
        {
            var room = new Garage();
            Assert.AreEqual("Garage", room.Name);
            Assert.IsFalse(room.HasBlinds);
            Assert.IsFalse(room.HasAwnings);
        }

        [TestMethod]
        public void TestWinterGardenProperties()
        {
            var room = new WinterGarden();
            Assert.AreEqual("Wintergarten", room.Name);
            Assert.IsFalse(room.HasBlinds);
            Assert.IsFalse(room.HasAwnings);
        }
        
        [TestMethod]
        public void TestBedroomPropertiesWithJalousien()
        {
            var room = new Bedroom();
            var jalousiencontroler = new Jalousiencontroler(room, new DummyOutput());
            Assert.AreEqual("Schlafzimmer", room.Name);
            Assert.IsTrue(room.HasBlinds);
            Assert.IsFalse(room.HasAwnings);
        }
        
        [TestMethod]
        public void TestWinterGartenPropertiesWithMarkisen()
        {
            var room = new WinterGarden();
            var markisensteuerung = new Markisensteuerung(room, new DummyOutput());
            Assert.AreEqual("Wintergarten", room.Name);
            Assert.IsFalse(room.HasBlinds);
            Assert.IsTrue(room.HasAwnings);
        }
        
        [TestMethod]
        public void TestWinterGartenPropertiesWithMarkisenAndJalousien()
        {
            var room = new WinterGarden();
            var roomWithMarkise = new Markisensteuerung(room, new DummyOutput());
            new Jalousiencontroler(roomWithMarkise.innerRoom, new DummyOutput());
            Assert.AreEqual("Wintergarten", room.Name);
            Assert.IsTrue(room.HasBlinds);
            Assert.IsTrue(room.HasAwnings);
        }
    }
}