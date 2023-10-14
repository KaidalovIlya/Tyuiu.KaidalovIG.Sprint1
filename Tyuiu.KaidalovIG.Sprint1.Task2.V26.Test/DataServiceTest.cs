using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint1.Task2.V26.Lib;

namespace Tyuiu.KaidalovIG.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.ConvertInchToKm(39);

            Assert.AreEqual(1, res);
        }
    }
}
