using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExFizzBuzzTDD.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {

        [TestMethod()]
        public void FizzBuzzCtorTest1()
        {
            FizzBuzz target = new FizzBuzz();
            Assert.AreNotEqual(null, target);
        }

        [TestMethod()]
        public void FizzBuzzCtorTest2()
        {
            FizzBuzz target = new FizzBuzz();
            Assert.AreEqual("1", target.Apply(1));
        }

        [TestMethod()]
        public void FizzBuzzCtorTest3()
        {
            FizzBuzz target = new FizzBuzz();
            Assert.AreEqual("2", target.Apply(2));
        }

        [TestMethod()]
        public void FizzBuzzCtorTest4()
        {
            FizzBuzz target = new FizzBuzz();
            Assert.AreEqual("Fizz", target.Apply(3));
        }

        [TestMethod()]
        public void FizzBuzzCtorTest5()
        {
            FizzBuzz target = new FizzBuzz();
            Assert.AreEqual("4", target.Apply(4));
        }

        [TestMethod()]
        public void FizzBuzzCtorTest6()
        {
            FizzBuzz target = new FizzBuzz();
            Assert.AreEqual("Buzz", target.Apply(5));
        }
    }
}