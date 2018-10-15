using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vectors;

namespace VectorTest
{
    [TestClass]
    public class VectorTest
    {
        private readonly double epsilon = 0.001;

        [TestMethod]
        public void TestLengthIsEqual()
        {
            var vector1 = new Vector(new double[] { 1, 2, 3 });
            var vector2 = new Vector(new double[] { 0, 2, 1 });

            Assert.AreEqual(Vector.GetScalarMultiplication(vector1, vector2), 7, epsilon);
        }

        [TestMethod]
        public void TestFirstLengthIsLess()
        {
            var vector1 = new Vector(new double[] { 1, 2 });
            var vector2 = new Vector(new double[] { 0, 2, 1 });

            Assert.AreEqual(Vector.GetScalarMultiplication(vector1, vector2), 4, epsilon);
        }

        [TestMethod]
        public void TestSecondLengthIsLess()
        {
            var vector1 = new Vector(new double[] { 1, 2, 3 });
            var vector2 = new Vector(new double[] { 2, 1 });

            Assert.AreEqual(Vector.GetScalarMultiplication(vector1, vector2), 4, epsilon);
        }
    }
}
