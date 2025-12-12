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
            var hv = new HeatingVent(new Bathroom());

            var sw = CaptureOutput();
            hv.Operate(externalTemperature: 5, roomTemperature: 20, windSpeed: 0, isRaining: false, peopleInRoom: true);
            ResetConsole();

            var output = sw.ToString();
            StringAssert.Contains(output, "geöffnet");
        }

        [TestMethod]
        public void HeatingVent_ClosesWhenWarm()
        {
            var hv = new HeatingVent(new Bathroom());
            
            hv.Operate(5, 20, 0, false, true);

            var sw = CaptureOutput();
            hv.Operate(externalTemperature: 25, roomTemperature: 20, windSpeed: 0, isRaining: false, peopleInRoom: true);
            ResetConsole();

            var output = sw.ToString();
            StringAssert.Contains(output, "geschlossen");
        }
    }
}