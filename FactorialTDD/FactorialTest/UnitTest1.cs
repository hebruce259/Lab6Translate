using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactorialTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatFactorialOf5Is120()
        {
                        
                long result = FactorialTDD.Program.calculateFactorial(5);
                Assert.AreEqual(120, result);
        }
        [TestMethod]
        public void TestThatFactorialOf1Is1()
        {

            long result = FactorialTDD.Program.calculateFactorial(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestThatFactorialOf3Is6()
        {

            long result = FactorialTDD.Program.calculateFactorial(3);
        Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void TestThatFactorialOf7Is5040()
        {

            long result = FactorialTDD.Program.calculateFactorial(7);
            Assert.AreEqual(5040, result);
        }
    }
}
