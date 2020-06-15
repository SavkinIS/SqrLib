using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqrLib;

namespace UnitTestSqr
{
    [TestClass]
    public class TestElipscs
    {

        /// <summary>
        /// Возвращат Ли число
        /// </summary>
        [TestMethod]
        public void TestNotNullTriangle()
        {
            Square s = new Square();

            Assert.IsNotNull(s.GetArea(5,6));
        }

        /// <summary>
        ///  /// проверка на верность подчета
        /// </summary>
        [TestMethod]
        public void TestCurentResultTriangle()
        {
            Square s = new Square();
            var res = s.GetArea(5,6);
            Assert.AreEqual(94.20000457763672 , res);
        }
    }
}
