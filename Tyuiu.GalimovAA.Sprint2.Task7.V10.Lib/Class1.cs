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

            // Для области между прямыми y = x и y = -x
            // Это эквивалентно: -|x| <= y <= |x|
            bool betweenLines = (y >= -Math.Abs(x)) && (y <= Math.Abs(x));

            return aboveParabola && betweenLines;
        }
    }
}