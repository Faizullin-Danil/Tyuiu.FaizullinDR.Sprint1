using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint1.Task7.V24.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var wait = -5.292;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
