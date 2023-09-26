using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint1.Task5.V4.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.Task5.V4
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
            Console.WriteLine("* Задание #5                                                                           *");
            Console.WriteLine("* Вариант #4                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                                 *");
            Console.WriteLine("* Идет k-я секунда суток.                                                              *");
            Console.WriteLine("* Определить, сколько полных часов (h) прошло к этому моменту.                         *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            int k;

            Console.WriteLine("Введите значение K:");
            k = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Количество полных часов к данному моменту = " + ds.SecondsToHours(k));
                
            Console.ReadLine();



        }
    }
}
