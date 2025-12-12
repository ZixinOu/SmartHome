using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace SmartHome.Tests
{
    [TestClass]
    public class TestHeatingVent
    {
        [TestMethod]
        public void HeatingVent_OpensWhenCold()
        {
            var output = new DummyOutput();
            var hv = new HeatingVent(new Bathroom(), output);
            
            hv.Operate(externalTemperature: 5, roomTemperature: 20, windSpeed: 0, isRaining: false, peopleInRoom: true);
            
            StringAssert.Contains(output.LastMessage, "geöffnet");
        }

        [TestMethod]
        public void HeatingVent_ClosesWhenWarm()
        {
            var output = new DummyOutput();
            var hv = new HeatingVent(new Bathroom(), output);
            
            hv.Operate(5, 20, 0, false, true);
            
            hv.Operate(externalTemperature: 25, roomTemperature: 20, windSpeed: 0, isRaining: false, peopleInRoom: true);
            
            StringAssert.Contains(output.LastMessage, "geschlossen");
        }
    }
}