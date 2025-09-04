using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovAA.Sprint2.Task7.V10.Lib
{
    public class DataService
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool aboveParabola = y >= (x * x - 2);     
            bool betweenLines = (y <= x) && (y >= -x); 

            return aboveParabola && betweenLines;
        }
    }
}