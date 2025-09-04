using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint2.Task1.V28.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(a, b, c, d);
            bool[] wait = { false, false, true, false, true, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}