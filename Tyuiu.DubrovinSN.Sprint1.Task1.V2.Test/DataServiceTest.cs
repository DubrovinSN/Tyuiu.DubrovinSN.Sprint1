using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint1.Task1.V2.Lib;

namespace Tyuiu.DubrovinSN.Sprint1.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MathCalculate()
        {   
            DataService ds = new DataService();
            double x = 1.0;
            double y = 12.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
