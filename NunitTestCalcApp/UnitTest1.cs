
using CalulatorAppwork;

namespace NunitTestCalcApp
{
    public class TestsClalApp
    {

        private CalulatorApp _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new CalulatorApp();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = _calculator.Add(3, 5);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Multi_TwoNumbers_ReturnsProduct()
        {
            int result = _calculator.Multi(4, 6);
            Assert.AreEqual(24, result);
        }

    }
}