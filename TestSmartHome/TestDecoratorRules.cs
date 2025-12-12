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
            try
            {
                _ = new HeatingVent(new WinterGarden());
                Assert.Fail("Expected InvalidOperationException was not thrown.");
            }
            catch (InvalidOperationException)
            {
            }
        }

        [TestMethod]
        public void HeatingVent_NotAllowedInGarage()
        {
            try
            {
                _ = new HeatingVent(new Garage());
                Assert.Fail("Expected InvalidOperationException was not thrown.");
            }
            catch (InvalidOperationException)
            {
            }
        }

        [TestMethod]
        public void HeatingVent_AllowedInBathroom()
        {
            var hv = new HeatingVent(new Bathroom());
            Assert.IsNotNull(hv);
        }

        [TestMethod]
        public void Jalousien_NotAllowedInBathroom()
        {
            try
            {
                _ = new Jalousiencontroler(new Bathroom());
                Assert.Fail("Expected InvalidOperationException was not thrown.");
            }
            catch (InvalidOperationException)
            {
            }
        }

        [TestMethod]
        public void Jalousien_NotAllowedInGarage()
        {
            try
            {
                _ = new Jalousiencontroler(new Garage());
                Assert.Fail("Expected InvalidOperationException was not thrown.");
            }
            catch (InvalidOperationException)
            {
            }
        }

        [TestMethod]
        public void Jalousien_AllowedInBedroom()
        {
            var jal = new Jalousiencontroler(new Bedroom());
            Assert.IsNotNull(jal);
        }

        [TestMethod]
        public void Markise_AllowedInWinterGarden()
        {
            var m = new Markisensteuerung(new WinterGarden());
            Assert.IsNotNull(m);
        }

        [TestMethod]
        public void Markise_NotAllowedInKitchen()
        {
            try
            {
                _ = new Markisensteuerung(new Kitchen());
                Assert.Fail("Expected InvalidOperationException was not thrown.");
            }
            catch (InvalidOperationException)
            {
            }
        }
    }
}
