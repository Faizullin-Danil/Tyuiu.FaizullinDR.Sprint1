using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint1.Task4.V20.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.Task4.V20
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
            Console.WriteLine("* Задание #4                                                                           *");
            Console.WriteLine("* Вариант #20                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,              *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                             *");
            Console.WriteLine("*                                                                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            int y;

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine(Math.Round(ds.Calculate(x, y),3));

            Console.ReadLine();
        }
    }
}
