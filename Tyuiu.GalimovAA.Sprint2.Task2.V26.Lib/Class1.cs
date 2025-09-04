using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GalimovAA.Sprint2.Task2.V26.Lib
{
    public class DataService : ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool inMainArea = (x >= 3 && x <= 5 && y >= 3 && y <= 7) ||
                             (x >= 6 && x <= 9 && y >= 5 && y <= 7) ||
                             (x >= 10 && x <= 12 && y >= 3 && y <= 7);
            bool inAdditionalArea = (x >= 7 && x <= 8 && y >= 8 && y <= 9) ||
                                   (x == 13 && y >= 6 && y <= 8);
            bool inSmallAreas = (x == 3 && y == 8) ||
                               (x == 4 && y == 8) ||
                               (x == 9 && y == 4) ||
                               (x == 10 && y == 8) ||
                               (x == 11 && y == 8);

            return inMainArea || inAdditionalArea || inSmallAreas;
        }
    }
}