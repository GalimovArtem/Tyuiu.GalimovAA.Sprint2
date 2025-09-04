using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.GalimovAA.Sprint2.Task1.V28.Lib
{
    public class DataService
    {
        public bool[] GetCompareOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // Операции сравнения в заданной последовательности
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