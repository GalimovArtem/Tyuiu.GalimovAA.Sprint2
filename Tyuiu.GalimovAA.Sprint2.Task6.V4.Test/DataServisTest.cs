using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint2.Task6.V4.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuit1()
        {
            DataService ds = new DataService();
            int value = 1;
            string wait = "пики";
            string res = ds.FindCardSuit(value);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardSuit2()
        {
            DataService ds = new DataService();
            int value = 2;
            string wait = "трефы";
            string res = ds.FindCardSuit(value);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardSuit3()
        {
            DataService ds = new DataService();
            int value = 3;
            string wait = "бубны";
            string res = ds.FindCardSuit(value);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidFindCardSuit4()
        {
            DataService ds = new DataService();
            int value = 4;
            string wait = "червы";
            string res = ds.FindCardSuit(value);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidFindCardSuit()
        {
            DataService ds = new DataService();
            int value = 5;
            ds.FindCardSuit(value);
        }
    }
}