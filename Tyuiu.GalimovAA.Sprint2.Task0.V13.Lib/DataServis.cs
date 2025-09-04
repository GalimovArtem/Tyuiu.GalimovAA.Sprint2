using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovAA.Sprint2.Task0.V13.Lib
{
    public class DataService : ISprint2Task0V13
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            
            results[0] = x == y;      
            results[1] = x != y;      
            results[2] = x < y;       
            results[3] = x > y;       
            results[4] = x <= y;      
            results[5] = x >= y;      

            return results;
        }
    }
}