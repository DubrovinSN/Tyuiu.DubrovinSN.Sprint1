using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint1.Task4.V11.Lib;

namespace Tyuiu.DubrovinSN.Sprint1.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Math()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 4;
            double wait = 0.026;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
