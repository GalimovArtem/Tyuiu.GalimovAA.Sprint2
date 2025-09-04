using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint2.Task3.V20.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXGreaterThan1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 18;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateXEquals0()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.833; 
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateXBetweenMinus24And2()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 4;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateXLessThanMinus24()
        {
            DataService ds = new DataService();
            double x = -25;
            double wait = -274.96;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidCalculateXEquals1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
        }
    }
}