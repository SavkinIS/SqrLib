using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqrLib;

namespace UnitTestSqr
{
    [TestClass]
    public class TestSquareCircle
    {
        /// <summary>
        /// ��������� �����
        /// </summary>
        [TestMethod]
        public void TestNotNullCircle()
        {
            Square s = new Square();

            Assert.IsNotNull(s.GetArea(25));
        }

        /// <summary>
        /// �������� �� �������� �������
        /// </summary>
        [TestMethod]
        public void TestCurentResultCircle()
        {
            Square s = new Square();

            Assert.AreEqual(50.2400016784668, s.GetArea(4));
        }

     
        




    }
}
