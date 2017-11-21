using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1_1_SquareEquation;

namespace UnitTests.SquareEquation
{
    [TestClass]
    public class Functions
    {
        [TestMethod]
        public void SolveSquareEquation()
        {
            const double a = 1, b = 2, c = -3;
            squareEquationRoots expected = squareEquationRoots.NewQuad(1, -3);

            squareEquationRoots result = solveSquareEquation(a, b, c);

            Assert.AreEqual(expected, result);
        }
    }
}