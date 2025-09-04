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
            DataService ds = new DataService();
            double x = 0;
            double y = -1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
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
            DataService ds = new DataService();
            double x = -1;
            double y = -1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea4()
        {
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
            DataService ds = new DataService();
            double x = -2;
            double y = 2;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}