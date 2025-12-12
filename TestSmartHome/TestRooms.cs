using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmartHome.Tests
{
    [TestClass]
    public class TestRooms
    {
        [TestMethod]
        public void TestBathroomProperties()
        {
            var r = new Bathroom();
            Assert.AreEqual("Bad/WC", r.Name);
            Assert.IsFalse(r.HasBlinds);
            Assert.IsFalse(r.HasAwnings);
        }

        [TestMethod]
        public void TestBedroomProperties()
        {
            var r = new Bedroom();
            Assert.AreEqual("Schlafzimmer", r.Name);
            Assert.IsTrue(r.HasBlinds);
            Assert.IsFalse(r.HasAwnings);
        }

        [TestMethod]
        public void TestKitchenProperties()
        {
            var r = new Kitchen();
            Assert.AreEqual("Küche", r.Name);
            Assert.IsTrue(r.HasBlinds);
            Assert.IsFalse(r.HasAwnings);
        }

        [TestMethod]
        public void TestLivingRoomProperties()
        {
            var r = new LivingRoom();
            Assert.AreEqual("Wohnzimmer", r.Name);
            Assert.IsTrue(r.HasBlinds);
            Assert.IsFalse(r.HasAwnings);
        }

        [TestMethod]
        public void TestGarageProperties()
        {
            var r = new Garage();
            Assert.AreEqual("Garage", r.Name);
            Assert.IsFalse(r.HasBlinds);
            Assert.IsFalse(r.HasAwnings);
        }

        [TestMethod]
        public void TestWinterGardenProperties()
        {
            var r = new WinterGarden();
            Assert.AreEqual("Wintergarten", r.Name);
            Assert.IsTrue(r.HasBlinds);
            Assert.IsTrue(r.HasAwnings);
        }
    }
}