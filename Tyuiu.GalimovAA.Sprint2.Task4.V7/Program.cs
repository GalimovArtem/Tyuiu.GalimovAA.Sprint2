using System;
using Tyuiu.GalimovAA.Sprint2.Task4.V7.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Галимов А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора. Если x - 10 > y + 2, то           *");
            Console.WriteLine("* z = (1 + sqrt(x+3)/x^2)^y, иначе x^3 + 2x + (6 + 4/y^2)                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine($"Значение выражения = {Math.Round(result, 3)}");

            Console.ReadKey();
        }
    }
}