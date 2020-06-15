using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqrLib;

namespace UnitTestSqr
{
    [TestClass]
    public class TestSquareCircle
    {
        /// <summary>
        /// Возвращат число
        /// </summary>
        [TestMethod]
        public void TestNotNullCircle()
        {
            Square s = new Square();

            Assert.IsNotNull(s.GetArea(25));
        }

        /// <summary>
        /// проверка на верность подчета
        /// </summary>
        [TestMethod]
        public void TestCurentResultCircle()
        {
            Square s = new Square();

            Assert.AreEqual(50.2400016784668, s.GetArea(4));
        }

     
        




    }
}
