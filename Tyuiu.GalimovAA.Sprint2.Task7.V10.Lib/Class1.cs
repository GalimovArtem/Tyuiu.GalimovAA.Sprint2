using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovAA.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверяем, находится ли точка в заштрихованной области
            // Область ограничена параболой y = x^2 - 2 и прямыми y = x и y = -x

            bool belowParabola = y <= (x * x - 2);     // Ниже или на параболе
            bool aboveLine1 = y >= x;                  // Выше или на прямой y = x
            bool aboveLine2 = y >= -x;                 // Выше или на прямой y = -x

            return belowParabola && aboveLine1 && aboveLine2;
        }
    }
}