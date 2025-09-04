using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.GalimovAA.Sprint2.Task3.V20.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task3.V20.Lib
{
    public class DataService : ISprint2Task3V20
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                double numerator = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
                double denominator = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
                y = numerator / denominator;
            }
            else if (x > -24 && x < 2)
            {
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            else if (x < -24)
            {
                y = x + 10 * x - (1 / x);
            }
            else
            {
             
                throw new ArgumentException("Значение x не попадает ни в один из допустимых интервалов");
            }

            return Math.Round(y, 3);
        }
    }
}