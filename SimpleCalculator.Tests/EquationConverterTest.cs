using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EquationConverterTest
    {
        [TestMethod]
        public void EnsureMathRouter()
        {
            EquationConverter equationCoverter = new EquationConverter();
            int expectedResult = 5;
            int actualResult = equationCoverter.MathRouter(3, '+', 2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
