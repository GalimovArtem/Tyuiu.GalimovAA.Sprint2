using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint2.Task4.V7.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            // x - 10 > y + 2 (true)
            DataService ds = new DataService();
            double x = 15;
            double y = 2;
            double wait = Math.Pow(1 + Math.Sqrt(x + 3) / Math.Pow(x, 2), y);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            // x - 10 > y + 2 (false)
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double wait = Math.Pow(x, 3) + 2 * x + (6 + 4 / Math.Pow(y, 2));
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            // Граничный случай: x - 10 = y + 2 (false)
            DataService ds = new DataService();
            double x = 15;
            double y = 3;
            double wait = Math.Pow(x, 3) + 2 * x + (6 + 4 / Math.Pow(y, 2));
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            // Проверка округления
            DataService ds = new DataService();
            double x = 12.5;
            double y = 3.2;
            double result = ds.Calculate(x, y);
            double roundedResult = Math.Round(result, 3);
            Assert.AreEqual(roundedResult, Math.Round(result, 3));
        }
    }
}