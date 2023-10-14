using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint1.Task4.V14.Lib;

namespace Tyuiu.KaidalovIG.Sprint1.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1, 1);

            Assert.AreEqual(0.73, res, 0.01);
        }
    }
}
