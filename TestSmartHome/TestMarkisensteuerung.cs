using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace SmartHome.Tests
{
    [TestClass]
    public class TestMarkisensteuerung
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
        public void Markise_Extends_WhenHotLowWindDry()
        {
            var m = new Markisensteuerung(new WinterGarden());

            var sw = CaptureOutput();
            m.Operate(30, 20, 10, false, false);
            ResetConsole();

            StringAssert.Contains(sw.ToString(), "ausgefahren");
        }

        [TestMethod]
        public void Markise_Retracts_WhenWindHigh()
        {
            var m = new Markisensteuerung(new WinterGarden());

            var sw = CaptureOutput();
            m.Operate(30, 20, 60, false, false);
            ResetConsole();

            StringAssert.Contains(sw.ToString(), "eingefahren");
        }
    }
}