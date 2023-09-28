using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint1.Task6.V8.Lib;

namespace Tyuiu.DubrovinSN.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Math()
        {
            string slovo = "корабль";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(slovo);
            string wait = "орабльк";
            Assert.AreEqual(wait, res);
        }
    }
}
