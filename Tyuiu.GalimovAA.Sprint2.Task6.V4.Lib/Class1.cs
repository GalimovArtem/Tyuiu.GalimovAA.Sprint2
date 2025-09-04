using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovAA.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int value)
        {
            return value switch
            {
                1 => "пики",
                2 => "трефы",
                3 => "бубны",
                4 => "червы",
                _ => throw new ArgumentException("Неверный номер масти. Допустимые значения: 1-4")
            };
        }
    }
}