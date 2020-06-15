using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqrLib;

namespace UnitTestSqr
{
    [TestClass]
    public class TestPoligon
    {
        /// <summary>
        /// Возвращат число
        /// </summary>
        [TestMethod]
        public void TestNotNullPoligon()
        {
            Square s = new Square();

            Assert.IsNotNull(s.GetArea(2, 2, 2, 2,2));
        }

        /// <summary>
        ///  /// проверка на верность подчета
        /// </summary>
        [TestMethod]
        public void TestCurentResultPoligon()
        {
            Square s = new Square();
            var res = s.GetArea(2, 2, 2, 2, 2);
            Assert.AreEqual(6.881909370422363, res);
        }

    }
}
