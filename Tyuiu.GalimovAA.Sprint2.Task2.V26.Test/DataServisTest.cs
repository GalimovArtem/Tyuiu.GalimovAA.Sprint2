using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint2.Task2.V26.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точки внутри заштрихованной области
            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));
            Assert.IsTrue(ds.CheckDotInShadedArea(5, 7));
            Assert.IsTrue(ds.CheckDotInShadedArea(7, 6));
            Assert.IsTrue(ds.CheckDotInShadedArea(11, 5));
            Assert.IsTrue(ds.CheckDotInShadedArea(8, 9));
            Assert.IsTrue(ds.CheckDotInShadedArea(13, 7));

            // Точки вне заштрихованной области
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 5));
            Assert.IsFalse(ds.CheckDotInShadedArea(6, 2));
            Assert.IsFalse(ds.CheckDotInShadedArea(14, 6));
            Assert.IsFalse(ds.CheckDotInShadedArea(9, 10));
        }
    }
}