using NUnit.Framework;
 
namespace CodeScreen.Assessments.Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciCalculatorTest
    {
        [TestCase]
        public void Test1()
        {
            Assert.AreEqual(0, FibonacciCalculator.Calculate(0));
        }

        [TestCase]
        public void Test2()
        {
             Assert.AreEqual(5, FibonacciCalculator.Calculate(5));
        }

        [TestCase]
        public void Test3()
        {
             Assert.AreEqual(6765, FibonacciCalculator.Calculate(20));
        }

        [TestCase]
        public void Test4()
        {
             Assert.AreEqual(75025, FibonacciCalculator.Calculate(25));
        }
    }
}