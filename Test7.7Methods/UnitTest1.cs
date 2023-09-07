
using _7._7Uzduotis_Methods_UnitTesting;
namespace Test7._7Methods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateArea()
        {
            double lenght = 20;
            double width = 5;
            double expected = 100;
            double actual = Program.CalculateRectangleArea(lenght, width);
            Assert.AreEqual(expected, actual);
        }
    }
}