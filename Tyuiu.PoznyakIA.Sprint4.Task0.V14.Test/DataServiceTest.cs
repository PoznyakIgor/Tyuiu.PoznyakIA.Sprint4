﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint4.Task0.V14.Lib;

namespace Tyuiu.PoznyakIA.Sprint4.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = ds.GetSumOddArrEl(numsArray);
            int wait = 30;
            Assert.AreEqual(res, wait);

        }
    }
}
