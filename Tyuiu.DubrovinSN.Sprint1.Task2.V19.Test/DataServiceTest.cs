using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint1.Task2.V19.Lib;

namespace Tyuiu.DubrovinSN.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Math()
        {
            DataService ds = new DataService();
            int d = 23;
            var res = ds.ConvertInchToKm(d);
            Assert.AreEqual(0.575, res);
        }
    }
}
