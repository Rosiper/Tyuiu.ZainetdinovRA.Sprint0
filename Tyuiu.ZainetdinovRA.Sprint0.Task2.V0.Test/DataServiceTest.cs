using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZainetdinovRA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ruslan";
            var res = DataService.GetMessage(name); 

            Assert.AreEqual("Hello, "+name+"", res);
        }
    } 
}
