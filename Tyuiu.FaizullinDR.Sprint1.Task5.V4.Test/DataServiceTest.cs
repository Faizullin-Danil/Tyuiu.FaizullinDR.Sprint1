using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint1.Task5.V4.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int k = 13257;
            var res = 3;
            var wait = ds.SecondsToHours(k);

            Assert.AreEqual(wait, res);

        }
    }
}
