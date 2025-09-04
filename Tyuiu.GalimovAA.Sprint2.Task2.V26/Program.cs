using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GalimovAA.Sprint2.Task2.V26.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Галимов А.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной области.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine($"Точка с координатами ({x},{y}) {(result ? "находится" : "не находится")} в заштрихованной области");

            Console.ReadKey();
        }
    }
}