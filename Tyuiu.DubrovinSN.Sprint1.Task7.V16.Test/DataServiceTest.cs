using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint1.Task7.V16.Lib;

namespace Tyuiu.DubrovinSN.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Math()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 1.022;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
