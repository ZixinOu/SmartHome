using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SmartHome.Tests
{
    [TestClass]
    public class TestDecoratorRules
    {

        [TestMethod]
        public void HeatingVent_NotAllowedInWinterGarden()
        {
            Assert.Throws<InvalidOperationException>(
                () => new HeatingVent(new WinterGarden(), new DummyOutput()));
        }

        [TestMethod]
        public void HeatingVent_NotAllowedInGarage()
        {
            Assert.Throws<InvalidOperationException>(
                () => new HeatingVent(new Garage(), new DummyOutput()));
        }

        [TestMethod]
        public void HeatingVent_AllowedInBathroom()
        {
            var hv = new HeatingVent(new Bathroom(), new DummyOutput());
            Assert.IsNotNull(hv);
        }

        [TestMethod]
        public void Jalousien_NotAllowedInBathroom()
        {
            Assert.Throws<InvalidOperationException>(
                () => new Jalousiencontroler(new Bathroom(), new DummyOutput()));
        }

        [TestMethod]
        public void Jalousien_NotAllowedInGarage()
        {
            Assert.Throws<InvalidOperationException>(
                () => new Jalousiencontroler(new Garage(), new DummyOutput()));
        }

        [TestMethod]
        public void Jalousien_AllowedInBedroom()
        {
            var jal = new Jalousiencontroler(new Bedroom(), new DummyOutput());
            Assert.IsNotNull(jal);
        }

        [TestMethod]
        public void Markise_AllowedInWinterGarden()
        {
            var m = new Markisensteuerung(new WinterGarden(), new DummyOutput());
            Assert.IsNotNull(m);
        }

        [TestMethod]
        public void Markise_NotAllowedInKitchen()
        {
            Assert.Throws<InvalidOperationException>(
                () => new Markisensteuerung(new Kitchen(), new DummyOutput()));
        }
    }
}
