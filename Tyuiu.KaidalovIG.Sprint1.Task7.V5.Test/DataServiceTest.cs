using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint1.Task7.V5.Lib;

namespace Tyuiu.KaidalovIG.Sprint1.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = ds.Calculate(1, 1);
            Assert.AreEqual(-2.314, wait, 0.001);
        }
    }
}
