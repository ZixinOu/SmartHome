using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace SmartHome.Tests
{
    [TestClass]
    public class TestJalousiencontroler
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
        public void Jalousien_Lowers_WhenHotAndNoPeople()
        {
            var jal = new Jalousiencontroler(new Bedroom());

            var sw = CaptureOutput();
            jal.Operate(30, 20, 0, false, false);
            ResetConsole();

            StringAssert.Contains(sw.ToString(), "runter");
        }

        [TestMethod]
        public void Jalousien_Raises_WhenPeoplePresent()
        {
            var jal = new Jalousiencontroler(new Bedroom());
            
            jal.Operate(30, 20, 0, false, false);

            var sw = CaptureOutput();
            jal.Operate(30, 20, 0, false, true);
            ResetConsole();

            StringAssert.Contains(sw.ToString(), "hoch");
        }
    }
}