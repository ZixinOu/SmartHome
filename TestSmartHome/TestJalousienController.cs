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
            var output = new FakeOutput();
            var jal = new Jalousiencontroler(new Bedroom(), output);

            jal.Operate(30, 20, 0, false, false);

            StringAssert.Contains(output.LastMessage, "runter");
        }

        [TestMethod]
        public void Jalousien_Raises_WhenPeoplePresent()
        {
            var output = new FakeOutput();
            var jal = new Jalousiencontroler(new Bedroom(), output);
            
            jal.Operate(30, 20, 0, false, false);

            jal.Operate(30, 20, 0, false, true);

            StringAssert.Contains(output.LastMessage, "hoch");
        }
    }
}