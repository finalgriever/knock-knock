using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockKnock.Models;

namespace KnockKnockTest
{
    [TestClass]
    public class FibonacciSequenceTest
    {
        [TestMethod]
        public void FibonacciNumbersAtAGivenIndexAreAsExpected()
        {
            var sequence = new FibonacciSequence();

            Assert.AreEqual(0, sequence[0]);
            Assert.AreEqual(3, sequence[4]);
            Assert.AreEqual(610, sequence[15]);
            Assert.AreEqual(2880067194370816120, sequence[90]);
        }
    }
}
