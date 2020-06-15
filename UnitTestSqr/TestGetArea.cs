using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqrLib;

namespace UnitTestSqr
{
    [TestClass]
   public  class TestGetArea
    {   

        /// <summary>
        /// Тест Проверяет возвражет ли метод отве -1 если массив не задан
        /// </summary>
        [TestMethod]
        public void ReturnError()
        {
            Square s = new Square();

            Assert.AreEqual(-1,s.GetArea());
        }

        /// <summary>
        /// Тест Проверяет возвражет ли метод отве -1 если массив Имеет отрицательное значение
        /// </summary>
        [TestMethod]
        public void ReturnErrorMinus()
        {
            Square s = new Square();

            Assert.AreEqual(-1, s.GetArea(-1,1));
        }

        /// <summary>
        /// Тест Проверяет возвражет ли метод отве -1 если массив Имеет сторону длиной 0
        /// </summary>
        [TestMethod]
        public void ReturnErrorZiro()
        {
            Square s = new Square();

            Assert.AreEqual(-1, s.GetArea(0, 1));
        }
    }
}
