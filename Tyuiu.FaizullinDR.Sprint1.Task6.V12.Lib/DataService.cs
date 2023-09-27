using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FaizullinDR.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            string[] s = value.Split(' ');
            
            string str = "";
            int a = s.Length - 1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                str += s[i] + ' ';
            }


            bool b = str.Contains(s[a]);

            //string lastWord = s[s.Length - 1];

            //return ((s.Count(x => x == lastWord)) > 1);

            return b;



        }
    }
}
