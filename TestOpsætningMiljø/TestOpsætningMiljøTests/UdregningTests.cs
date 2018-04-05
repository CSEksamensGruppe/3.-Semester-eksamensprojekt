using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestOpsætningMiljø;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOpsætningMiljø.Tests
{
    [TestClass()]
    public class UdregningTests
    {
        [TestMethod()]
        public void DivisionTest()
        {
            Udregning udregning = new Udregning();

            double actualvalue = udregning.Division(10, 2);
            double expectedvalue = 5;


            Assert.AreEqual(expectedvalue, actualvalue);
        }
    }
}