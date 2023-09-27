using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint1.Task5.V6.Lib;

namespace Tyuiu.DubrovinSN.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Math()
        {
            int k = 7;
            DataService ds = new DataService();
            int res = ds.Calculate(k);
            Assert.AreEqual(res, 7);

        }
    }
}
