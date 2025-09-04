using System;
using Tyuiu.GalimovAA.Sprint2.Task6.V4.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Галимов А. А. | ПКТ6-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма записи оператора switch                         *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТ6-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти «червы» —4*");
            Console.WriteLine("* По заданному номеру масти m (1 <= m <= 4) определить название           *");
            Console.WriteLine("* соответствующей масти.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти (1-4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                string result = ds.FindCardSuit(m);
                Console.WriteLine($"Масть с номером {m}: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}