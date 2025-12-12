using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace SmartHome.Tests
{
    [TestClass]
    public class TestMarkisensteuerung
    {
      
        [TestMethod]
        public void Markise_Extends_WhenHotLowWindDry()
        {
            var output = new DummyOutput();
            var m = new Markisensteuerung(new WinterGarden(), output);

            m.Operate(30, 20, 10, false, false);

            StringAssert.Contains(output.LastMessage,"ausgefahren");
        }

        [TestMethod]
        public void Markise_Retracts_WhenWindHigh()
        {
            var output = new DummyOutput();
            var m = new Markisensteuerung(new WinterGarden(), output);

            m.Operate(30, 20, 60, false, false);
            StringAssert.Contains(output.LastMessage,"eingefahren");
        }
    }
}