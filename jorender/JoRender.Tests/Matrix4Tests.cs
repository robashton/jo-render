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
            Matrix4 result = matrixOne.Multiply(matrixTwo);         
          
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


        // Calculate determinant

        [Test]
        public void When_Calculating_Determinant_Of_Matrix_Double_With_Result_Is_Returned()
        {
            //Arrange
            Matrix4 matrixOne = new Matrix4(1.0, 2.0, 0.0, 3.0, 3.0, 2.0, 1.0, 2.0, 1.0, 0.0, 1.0, 1.0, 2.0, 1.0, 3.0, 3.0);

            //Act
            double result = matrixOne.Determinant();
            
            //Assert
            Assert.AreEqual(9.0, result);
        }

        //Calculate adjoint

        [Test]
        public void When_Calculating_Adjoint_Of_Matrix_Matrix_With_Result_Is_Returned()
        {
            //Arrange
            Matrix4 matrixOne = new Matrix4(1.0, 2.0, 0.0, 3.0, 3.0, 2.0, 1.0, 2.0, 1.0, 0.0, 1.0, 1.0, 2.0, 1.0, 3.0, 3.0);

            //Act
            Matrix4 result = matrixOne.Adjoint();

            //Assert
            Assert.AreEqual(-1.0, result.XX);
            Assert.AreEqual(3.0, result.XY);
            Assert.AreEqual(9.0, result.XZ);
            Assert.AreEqual(-4.0, result.XW);
            Assert.AreEqual(-1.0, result.YX);
            Assert.AreEqual(3.0, result.YY);
            Assert.AreEqual(-18.0, result.YZ);
            Assert.AreEqual(5.0, result.YW);
            Assert.AreEqual(-3.0, result.ZX);
            Assert.AreEqual(0.0, result.ZY);
            Assert.AreEqual(-9.0, result.ZZ);
            Assert.AreEqual(6.0, result.ZW);
            Assert.AreEqual(4.0, result.WX);
            Assert.AreEqual(-3.0, result.WY);
            Assert.AreEqual(9.0, result.WZ);
            Assert.AreEqual(-2.0, result.WW);
        }

        // Calculate inverse

        [Test]
        public void When_Calculating_Inverse_Of_Matrix_Matrix_With_Result_Is_Returned()
        {
            //Arrange
            Matrix4 matrixOne = new Matrix4(1.0, 2.0, 0.0, 3.0, 3.0, 2.0, 1.0, 2.0, 1.0, 0.0, 1.0, 1.0, 2.0, 1.0, 3.0, 3.0);

            //Act
            Matrix4 result = matrixOne.Inverse();

            //Assert
            Assert.AreEqual((-1.0/9.0), result.XX);
            Assert.AreEqual((1.0/3.0), result.XY);
            Assert.AreEqual(1.0, result.XZ);
            Assert.AreEqual((-4.0/9.0), result.XW);
            Assert.AreEqual((-1.0/9.0), result.YX);
            Assert.AreEqual((1.0/3.0), result.YY);
            Assert.AreEqual(-2.0, result.YZ);
            Assert.AreEqual((5.0/9.0), result.YW);
            Assert.AreEqual((-1.0/3.0), result.ZX);
            Assert.AreEqual(0.0, result.ZY);
            Assert.AreEqual(-1.0, result.ZZ);
            Assert.AreEqual((2.0/3.0), result.ZW);
            Assert.AreEqual((4.0/9.0), result.WX);
            Assert.AreEqual((-1.0/3.0), result.WY);
            Assert.AreEqual(1.0, result.WZ);
            Assert.AreEqual((-2.0/9.0), result.WW);
        }


        // Create identity matrix

        [Test]
        public void An_Identity_Matrix_Is_Returned()
        {
            //Arrange

            //Act
            Matrix4 result = Matrix4.Identity();

            //Assert

            Assert.AreEqual(1.0, result.XX);
            Assert.AreEqual(0.0, result.XY);
            Assert.AreEqual(0.0, result.XZ);
            Assert.AreEqual(0.0, result.XW);
            Assert.AreEqual(0.0, result.YX);
            Assert.AreEqual(1.0, result.YY);
            Assert.AreEqual(0.0, result.YZ);
            Assert.AreEqual(0.0, result.YW);
            Assert.AreEqual(0.0, result.ZX);
            Assert.AreEqual(0.0, result.ZY);
            Assert.AreEqual(1.0, result.ZZ);
            Assert.AreEqual(0.0, result.ZW);
            Assert.AreEqual(0.0, result.WX);
            Assert.AreEqual(0.0, result.WY);
            Assert.AreEqual(0.0, result.WZ);
            Assert.AreEqual(1.0, result.WW);

        }

        
        // Calculate other crazy value shit

  
    }
}
