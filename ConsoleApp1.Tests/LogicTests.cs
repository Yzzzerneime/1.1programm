using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaComparison;

namespace AreaComparison.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void SquareLargerThanCircleTest()
        {
            var result = Logic.CompareAreas(5.0, 5.0);
            Assert.AreEqual("круг больше!", result);
        }

        [TestMethod]
        public void CircleLargerThanSquareTest()
        {
            var result = Logic.CompareAreas(5.0, 10.0);
            Assert.AreEqual("квадрат больше!", result);
        }

        [TestMethod]
        public void GetCircleAreaTest()
        {
            var area = Logic.GetCircleArea(5.0);
            Assert.AreEqual(78.5, area);
        }

        [TestMethod]
        public void GetSquareAreaTest()
        {
            var area = Logic.GetSquareArea(5.0);
            Assert.AreEqual(25.0, area);
        }
    }
}