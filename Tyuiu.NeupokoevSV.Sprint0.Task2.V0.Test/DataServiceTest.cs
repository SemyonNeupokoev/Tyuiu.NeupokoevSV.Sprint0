﻿using Tyuiu.NeupokoevSV.Sprint0.Task2.V0.Lib;
using System;
using Tyuiu.NeupokoevSV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.NeupokoevSV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Семён";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Семён", res);
        }
    }
}
