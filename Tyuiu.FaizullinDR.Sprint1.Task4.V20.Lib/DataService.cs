﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FaizullinDR.Sprint1.Task4.V20.Lib
{ 
    public class DataService : ISprint1Task4V20
    {
        public double Calculate(double x, double y)
        {
            var res = (x + 1) / (Math.Abs(x - Math.Sqrt(2 + y)));
            return res;
        }
    }
}
