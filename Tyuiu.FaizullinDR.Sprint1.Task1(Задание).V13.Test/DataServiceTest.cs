using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint1.Task1.V13.Lib;

// x / (0.5 * x)

namespace Tyuiu.FaizullinDR.Sprint1.Task1_Задание_.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }
    }
}
