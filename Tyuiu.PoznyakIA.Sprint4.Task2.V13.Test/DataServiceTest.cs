using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint4.Task2.V13.Lib;
namespace Tyuiu.PoznyakIA.Sprint4.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 13824;
            Assert.AreEqual(res, wait);
        }
    }
}
