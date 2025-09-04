using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovAA.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Заштрихованная область находится ВЫШЕ параболы y = x^2 - 2
            // и МЕЖДУ прямыми y = x и y = -x

            bool aboveParabola = y >= (x * x - 2);     // Выше или на параболе
            bool betweenLines = Math.Abs(y) <= Math.Abs(x); // Между прямыми

            return aboveParabola && betweenLines;
        }
    }
}