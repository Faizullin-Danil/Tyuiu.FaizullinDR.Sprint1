using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint1.Task3.V5.Lib;

namespace Tyuiu.FaizullinDR.Sprint1.Task3.V5
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
            Console.WriteLine("* Задание #3                                                                           *");
            Console.WriteLine("* Вариант#5                                                                            *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать програумму, которая запрашивает у пользователя исходные данные,             *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                          *");
            Console.WriteLine("*                                                                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            double x = 120;
            double y = 3.5;
            Console.WriteLine("Масштаб карты(количество км. в одном см.) = " + x); 
            Console.WriteLine("Расстояние между точками, изображающими населенные пункты (см) = " + y);
            


            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Расстояние между населенными пунктами = " + ds.DistanceLength(x,y));

            Console.ReadLine();
        }
    }
}
