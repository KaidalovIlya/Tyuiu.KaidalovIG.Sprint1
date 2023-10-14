using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint1.Task3.V5.Lib;

namespace Tyuiu.KaidalovIG.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.VerstsToKilometers(100);
            Assert.AreEqual(106.68, res, 0.01);
        }
    }
}
