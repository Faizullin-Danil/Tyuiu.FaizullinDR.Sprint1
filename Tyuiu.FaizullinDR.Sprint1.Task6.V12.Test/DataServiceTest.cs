using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint1.Task6.V12.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestString()
        {
            DataService ds = new DataService();

            string strg = "вася кот андрей кот";
            bool res = true;
            bool wait = ds.CheckLastWordRepetiton(strg);
            Assert.AreEqual(wait, res);

        }
    }
}
