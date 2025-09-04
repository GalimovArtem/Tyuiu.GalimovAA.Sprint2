using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovAA.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool belowParabola = y <= (x * x - 2);     
            bool aboveLineX = y >= x;                  
            bool aboveLineMinusX = y >= -x;            
            return belowParabola && aboveLineX && aboveLineMinusX;
        }
    }
}