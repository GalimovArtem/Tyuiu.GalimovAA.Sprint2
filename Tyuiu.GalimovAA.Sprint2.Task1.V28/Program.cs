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

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine($"D = {d}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Результат[{i}] = {result[i]}");
            }

            Console.ReadKey();
        }
    }
}