using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace SmartHome.Tests
{
    [TestClass]
    public class TestHeatingVent
    {
        private StringWriter CaptureOutput()
        {
            var sw = new StringWriter();
            Console.SetOut(sw);
            return sw;
        }

        private void ResetConsole()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
        }

        [TestMethod]
        public void HeatingVent_OpensWhenCold()
        {
            var output = new FakeOutput();
            var hv = new HeatingVent(new Bathroom(), output);
            
            hv.Operate(externalTemperature: 5, roomTemperature: 20, windSpeed: 0, isRaining: false, peopleInRoom: true);
            
            StringAssert.Contains(output.LastMessage, "geöffnet");
        }

        [TestMethod]
        public void HeatingVent_ClosesWhenWarm()
        {
            var output = new FakeOutput();
            var hv = new HeatingVent(new Bathroom(), output);
            
            hv.Operate(5, 20, 0, false, true);
            
            hv.Operate(externalTemperature: 25, roomTemperature: 20, windSpeed: 0, isRaining: false, peopleInRoom: true);
            
            StringAssert.Contains(output.LastMessage, "geschlossen");
        }
    }
}