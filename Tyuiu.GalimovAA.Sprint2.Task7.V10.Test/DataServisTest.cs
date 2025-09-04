using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint2.Task7.V10.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точка внутри заштрихованной области
            Assert.IsTrue(ds.CheckDotInShadedArea(0, -1));
            Assert.IsTrue(ds.CheckDotInShadedArea(0, -2));
            Assert.IsTrue(ds.CheckDotInShadedArea(1, -1));
            Assert.IsTrue(ds.CheckDotInShadedArea(-1, -1));

            // Точка на границах
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0)); // На пересечении границ
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 1)); // На прямой y = x
            Assert.IsTrue(ds.CheckDotInShadedArea(-1, 1)); // На прямой y = -x
            Assert.IsTrue(ds.CheckDotInShadedArea(Math.Sqrt(2), 0)); // На параболе

            // Точка вне заштрихованной области
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 2)); // Выше всех границ
            Assert.IsFalse(ds.CheckDotInShadedArea(-2, 2)); // Выше всех границ
            Assert.IsFalse(ds.CheckDotInShadedArea(0, 2)); // Выше всех границ
            Assert.IsFalse(ds.CheckDotInShadedArea(2, -2)); // Ниже параболы
        }
    }
}