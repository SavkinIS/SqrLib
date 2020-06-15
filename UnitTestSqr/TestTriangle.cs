using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqrLib;


namespace UnitTestSqr
{
    [TestClass]
    public class TestTriangle
    {
        /// <summary>
        /// Возвращат число
        /// </summary>
        [TestMethod]
        public void TestNotNullTriangle()
        {
            Square s = new Square();

            Assert.IsNotNull(s.GetArea(2, 2, 3));
        }

        /// <summary>
        ///  /// проверка на верность подчета
        /// </summary>
        [TestMethod]
        public void TestCurentResultTriangle()
        {
            Square s = new Square();
            var res = s.GetArea(2, 2, 2);
            Assert.AreEqual(1.732050895690918, res);
        }

    }
}
