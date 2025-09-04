using System;
using Tyuiu.GalimovAA.Sprint2.Task1.V28.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Галимов А.А. | ПКТб-24-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                           *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #28                                                                *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                               *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу из операций сравнений и вернуть логическую              *");
            Console.WriteLine("* последовательность (True, False, True, False, True, False)                 *");
            Console.WriteLine("* при a = 247, b = 654, c = 671, d = 671                                     *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("* a = " + a);
            Console.WriteLine("* b = " + b);
            Console.WriteLine("* c = " + c);
            Console.WriteLine("* d = " + d);
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}