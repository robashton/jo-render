using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using JoRender;

namespace JoRender.Tests
{
    [TestFixture]
    public class Vector3Tests
    {
        [Test]
        public void When_Adding_Two_Vectors_Vector_With_Result_Is_Returned()
        {
            // Arrange
            Vector3 vectorOne = new Vector3(1.0, 1.0, 1.0);
            Vector3 vectorTwo = new Vector3(2.0, 3.0, 4.0);

            // Act
            Vector3 result = vectorOne.Add(vectorTwo);

            // Assert
            Assert.AreEqual(3, result.X);
            Assert.AreEqual(4, result.Y);
            Assert.AreEqual(5, result.Z);
        }

        [Test]
        public void When_Multiplying_A_Vector_With_A_Scalar_Vector_With_Result_Is_Returned()
        {
            // Arrange
            Vector3 vectorOne = new Vector3(1.0, 2.0, 3.0);
            double scalarOne = 2;

            // Act
            Vector3 result = vectorOne.Multiply(scalarOne);

            // Assert
            Assert.AreEqual(2, result.X);
            Assert.AreEqual(4, result.Y);
            Assert.AreEqual(6, result.Z);

        }
    }
}
