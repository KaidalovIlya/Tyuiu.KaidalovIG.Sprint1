using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint1.Task6.V16.Lib;

namespace Tyuiu.KaidalovIG.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = ds.DeleteLastLetter("Привет");
            Assert.AreEqual("Приве ", wait);
        }
    }
}
