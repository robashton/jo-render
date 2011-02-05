using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using JoRender;

namespace JoRender.Tests
{
    [TestFixture]
    public class Matrix4Tests
    {
        // Multiply a matrix by scalar

        [Test]
        public void When_Multiplying_A_Matrix_By_A_Scalar_Matrix_With_Result_Is_Returned()
        {
            //Arrange
            Matrix4 matrixOne = new Matrix4(1.0, 2.0, 3.0, 4.0, 2.0, 3.0, 4.0, 5.0, 3.0, 4.0, 5.0, 6.0, 4.0, 5.0, 6.0, 7.0);
            double scalarOne = 2.0;

            //Act
            Matrix4 result = matrixOne.Multiply(scalarOne);

            //Assert
            Assert.AreEqual(2.0, result.XX);
            Assert.AreEqual(4.0, result.XY);
            Assert.AreEqual(6.0, result.XZ);
            Assert.AreEqual(8.0, result.XW);
            Assert.AreEqual(4.0, result.YX);
            Assert.AreEqual(6.0, result.YY);
            Assert.AreEqual(8.0, result.YZ);
            Assert.AreEqual(10.0, result.YW);
            Assert.AreEqual(6.0, result.ZX);
            Assert.AreEqual(8.0, result.ZY);
            Assert.AreEqual(10.0, result.ZZ);
            Assert.AreEqual(12.0, result.ZW);
            Assert.AreEqual(8.0, result.WX);
            Assert.AreEqual(10.0, result.WY);
            Assert.AreEqual(12.0, result.WZ);
            Assert.AreEqual(14.0, result.WW);
        }

        
        // Multiply two matrices

        [Test]
        public void When_Multiplying_Two_Matrices_Matrix_With_Result_Is_Returned()
        {
            //Arrange
            Matrix4 matrixOne = new Matrix4(1.0, 2.0, 3.0, 4.0, 2.0, 3.0, 4.0, 1.0, 3.0, 4.0, 1.0, 2.0, 4.0, 1.0, 2.0, 3.0);
            Matrix4 matrixTwo = new Matrix4(1.0, 2.0, 5.0, 3.0, 3.0, 5.0, 4.0, 1.0, 1.0, 3.0, 2.0, 4.0, 2.0, 4.0, 1.0, 5.0);

            //Act
            Matrix4 result = matrixOne.MultiplyM(matrixTwo);         
          
            //Assert
            Assert.AreEqual(18.0, result.XX);
            Assert.AreEqual(37.0, result.XY);
            Assert.AreEqual(23.0, result.XZ);
            Assert.AreEqual(37.0, result.XW);
            Assert.AreEqual(17.0, result.YX);
            Assert.AreEqual(35.0, result.YY);
            Assert.AreEqual(31.0, result.YZ);
            Assert.AreEqual(30.0, result.YW);
            Assert.AreEqual(20.0, result.ZX);
            Assert.AreEqual(37.0, result.ZY);
            Assert.AreEqual(35.0, result.ZZ);
            Assert.AreEqual(27.0, result.ZW);
            Assert.AreEqual(15.0, result.WX);
            Assert.AreEqual(31.0, result.WY);
            Assert.AreEqual(31.0, result.WZ);
            Assert.AreEqual(36.0, result.WW);
        }



        // Create origin matrix

        // Calculate inverse

        // Calculate other crazy value shit

  
    }
}
