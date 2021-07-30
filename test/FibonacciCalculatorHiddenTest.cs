using NUnit.Framework;
 
namespace CodeScreen.Assessments.Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciCalculatorHiddenTest
    {
        [TestCase]
        public void TestHidden1()
        {
            Assert.AreEqual(377, FibonacciCalculator.Calculate(14));
        }

        [TestCase]
        public void TestHidden2()
        {
             Assert.AreEqual(610, FibonacciCalculator.Calculate(15));
        }

        [TestCase]
        public void TestHidden3()
        {
             Assert.AreEqual(2584, FibonacciCalculator.Calculate(18));
        }

        [TestCase]
        public void TestHidden4()
        {
             Assert.AreEqual(4181, FibonacciCalculator.Calculate(19));
        }
    }
}