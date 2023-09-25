using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FaizullinDR.Sprint1.Task4.V20.Lib;
 
namespace Tyuiu.FaizullinDR.Sprint1.Task4.V20.Test
{ 
    [TestClass]
    public class DataServiceTest  
    { 
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 7;
            var res = ds.Calculate(x, y);
            var wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
