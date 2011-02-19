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
        // Adding two Vectors

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

        // Multiplying a Vector with a Scalar
        
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


        // Multiply two vectors - dot product

        [Test]
        public void When_Dot_Product_Multiplying_Two_Vectors_Scalar_With_Result_Is_Returned()
        {
            //Arrange
            Vector3 vectorOne = new Vector3(1.0, 2.0, 3.0);
            Vector3 vectorTwo = new Vector3(2.0, 3.0, 4.0);

            //Act
            double result = vectorOne.MultiplyVdot(vectorTwo);

            //Assert
            Assert.AreEqual(20, result);
        }

        // Multiply two vectors - cross product

        [Test]
        public void When_Cross_Product_Multiplying_Two_Vectors_Vector_With_Result_Is_Returned()
        {
            //Arrange
            Vector3 vectorOne = new Vector3(1.0, 2.0, 3.0);
            Vector3 vectorTwo = new Vector3(2.0, 3.0, 4.0);

            //Act
            Vector3 result = vectorOne.MultiplyVcross(vectorTwo);

            //Assert
            Assert.AreEqual(-1.0, result.X);
            Assert.AreEqual(2.0, result.Y);
            Assert.AreEqual(-1.0, result.Z);
        }

        // Multiply by a matrix

        [Test]
        public void When_Vector_Multiplied_With_A_Matrix_Vector_With_Result_Is_Returned()
        {
            //Arrange
            Vector3 vectorOne = new Vector3(3.0, 2.0, 1.0);
            Matrix4 matrixOne = new Matrix4(1.0, 2.0, 3.0, 4.0, 2.0, 3.0, 4.0, 1.0, 3.0, 4.0, 1.0, 2.0, 4.0, 1.0, 2.0, 3.0);

            //Act
            Vector3 result = vectorOne.MultiplyM(matrixOne);

            //Assert
            Assert.AreEqual(result.X, 14.0);
            Assert.AreEqual(result.Y, 17.0);
            Assert.AreEqual(result.Z, 20.0);
        }

       
    }
}
