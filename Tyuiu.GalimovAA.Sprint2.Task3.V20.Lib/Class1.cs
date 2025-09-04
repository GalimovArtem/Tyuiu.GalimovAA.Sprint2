using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovAA.Sprint2.Task3.V20.Lib
{
    public class DataService : ISprint2Task3V20
    {
        public double Calculate(double x)
        {
            if (x > 1)
            {
                return x * Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                return Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            }
            else if (x < 2)
            {
                if (x < -24)
                {
                    return x + 10 * x - (1 / x);
                }
                else if (x > -24 && x < 2)
                {
                    return Math.Pow(1 + 1 / Math.Pow(x, 2), x);
                }
                else
                {
                    return Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
                }
            }
            else
            {
                return 0; // Для случаев, не покрытых условиями
            }
        }
    }
}