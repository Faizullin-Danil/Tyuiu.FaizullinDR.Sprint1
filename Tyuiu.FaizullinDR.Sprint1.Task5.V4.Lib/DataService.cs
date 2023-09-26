using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FaizullinDR.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
       
            var k = Convert.ToDouble(time);
            var res = Math.Truncate(k / 3600);
            var result = Convert.ToInt32(res);
            return result;
        }
    }
}
