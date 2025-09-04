using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalimovAA.Sprint2.Task5.V12.Lib;

namespace Tyuiu.GalimovAA.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            // Тест 1: Обычный день в середине месяца
            Assert.AreEqual("2024.02.14", ds.FindDateOfPreviousDay(2024, 2, 15));

            // Тест 2: Первый день месяца
            Assert.AreEqual("2024.01.31", ds.FindDateOfPreviousDay(2024, 2, 1));

            // Тест 3: Первый день года
            Assert.AreEqual("2023.12.31", ds.FindDateOfPreviousDay(2024, 1, 1));

            // Тест 4: Високосный год, 1 марта
            Assert.AreEqual("2024.02.29", ds.FindDateOfPreviousDay(2024, 3, 1));

            // Тест 5: Не високосный год, 1 марта
            Assert.AreEqual("2023.02.28", ds.FindDateOfPreviousDay(2023, 3, 1));

            // Тест 6: 1 января
            Assert.AreEqual("2023.12.31", ds.FindDateOfPreviousDay(2024, 1, 1));
        }

        [TestMethod]
        public void InvalidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            // Тест с неверными данными
            Assert.AreEqual("Неверные входные данные", ds.FindDateOfPreviousDay(2024, 13, 1));
            Assert.AreEqual("Неверные входные данные", ds.FindDateOfPreviousDay(2024, 2, 32));
        }
    }
}