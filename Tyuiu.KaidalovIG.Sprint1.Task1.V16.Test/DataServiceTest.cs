using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint1.Task1.V16.Lib;

namespace Tyuiu.KaidalovIG.Sprint1.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 1;
            double x = 1;
            double y = 1;
            double res = ds.Calculate(a, x, y);
            Assert.AreEqual(7, res);
        }
    }
}
