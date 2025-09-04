using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint2.Task7.V10.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            // Точка внутри области (0, 0)
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            // Точка на параболе (1, -1)
            DataService ds = new DataService();
            double x = 1;
            double y = -1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea3()
        {
            // Точка на прямой y = x (1, 1)
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea4()
        {
            // Точка вне области (2, 2) - выше обеих прямых
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea5()
        {
            // Точка вне области (0, -3) - ниже параболы
            DataService ds = new DataService();
            double x = 0;
            double y = -3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea6()
        {
            // Точка (0.4, -1.5) - должна быть в области
            DataService ds = new DataService();
            double x = 0.4;
            double y = -1.5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}