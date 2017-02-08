using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.StoredConstants;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class StoredConstantsTest
    {
        [TestMethod]
        public void EnsureInDictionary()
        {
            StoredConstants constants = new StoredConstants();
            bool expectedResult = true;
            bool actualResult = constants.AddConstantsToDictionary('c', 4);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}