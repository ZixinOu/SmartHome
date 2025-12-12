using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace SmartHome.Tests
{
    [TestClass]
    public class TestJalousiencontroler
    {

        [TestMethod]
        public void Jalousien_Lowers_WhenHotAndNoPeople()
        {
            var output = new DummyOutput();
            var jal = new Jalousiencontroler(new Bedroom(), output);

            jal.Operate(30, 20, 0, false, false);

            StringAssert.Contains(output.LastMessage, "runter");
        }

        [TestMethod]
        public void Jalousien_Raises_WhenPeoplePresent()
        {
            var output = new DummyOutput();
            var jal = new Jalousiencontroler(new Bedroom(), output);
            
            jal.Operate(30, 20, 0, false, false);

            jal.Operate(30, 20, 0, false, true);

            StringAssert.Contains(output.LastMessage, "hoch");
        }
    }
}