using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalimovAA.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool aboveParabola = y >= (x * x - 2);
            bool belowLineYequalsX = y <= x;
            bool belowLineYequalsMinusX = y <= (-x);
            return aboveParabola && belowLineYequalsX && belowLineYequalsMinusX;
        }
    }
}