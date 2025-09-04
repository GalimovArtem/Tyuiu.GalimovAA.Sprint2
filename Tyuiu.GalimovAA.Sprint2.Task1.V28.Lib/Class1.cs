using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovAA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = a == b;      // =
            res[1] = c != d;      // !=
            res[2] = a < b;       // <
            res[3] = c > d;       // >
            res[4] = a <= b;      // <=
            res[5] = c >= d;      // >=

            return res;
        }
    }
}