using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint1.Task7.V24.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.Task7.V24
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
            Console.WriteLine("* Тема: Арифметические операторы в C#                                                  *");
            Console.WriteLine("* Задание #7                                                                           *");
            Console.WriteLine("* Вариант #24                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу,                                                                  *");
            Console.WriteLine("* которая вычисляет математическое выражение по исходным значениям данных,             *");
            Console.WriteLine("* вводимых пользователем. Ответ округлить до 3 знаков после запятой.                   *");
            Console.WriteLine("*      1+cos(√(x+1))                                                                   *");
            Console.WriteLine("* z =  -------------                                                                   *");
            Console.WriteLine("*       sin(15y-4)                                                                     *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");



            Console.WriteLine("Введите знвчени X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите знвчени Y:");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine(ds.Calculate(x,y));

            Console.ReadLine();
        }
    }
}
