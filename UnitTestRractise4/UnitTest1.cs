using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRractise4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double e = 0.09;

            double expected = 0;
            double actual = Sum(e);
            Assert.AreEqual(expected, actual);
        }
        public static double Sum(double e)
        {
            double a = 1.0, b = 25.0;
            double r = 0, y = 0;

            do
            {
                r += y;
                y = 1.0 / (a + b);
                a *= 4;
                b *= 5;
            } while (y > e);
            return r;
        }
    }
}