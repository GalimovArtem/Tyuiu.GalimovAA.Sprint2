using System;
using Tyuiu.GalimovAA.Sprint2.Task5.V12.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Галимов А. А. | ПКТ6-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТ6-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                       *");
            Console.WriteLine("* По заданным g, n и m определить дату предыдущего дня.                   *");
            Console.WriteLine("* Заданный год является високосным.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год (g): ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfPreviousDay(g, m, n);
            Console.WriteLine($"Дата предыдущего дня: {result}");

            Console.ReadKey();
        }
    }
}