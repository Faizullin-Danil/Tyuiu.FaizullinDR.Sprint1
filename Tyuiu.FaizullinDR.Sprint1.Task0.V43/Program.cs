using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint1.Task0.V4.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.Task0.V43
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Файзуллин Д. Р. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                            *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                     *");
            Console.WriteLine("* Задание #0                                                                           *");
            Console.WriteLine("*  Вариант#4                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать консольную программу, которая вычисляет выражение 4/2*5/(3+2)*(5-2)         *");
            Console.WriteLine("* И печатать результат на экране.                                                      *");
            Console.WriteLine("*                                                                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* 4/2*5/(3+2)*(5-2)                                                                    *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadKey();
        }
    }
}
