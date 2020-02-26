using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PROG2070Assignment2.Tests
{
    [TestFixture]
    public class AnalyzeTrianglesTest
    {

        /// <summary>
        /// Testing the Analyze method by giving side 1 as negative side (-4) and others as positive
        /// To check if the triangle can be formed or not by giving these sides as arguments 
        /// The result will give: The triangle cannot be formed
        /// </summary>
        [Test]
        public void AnalyzeMethod_GivenNegativeSides_CannotFormTriangle()
        {
            //Arrange
            string answer = "";
            int side1 = -4;
            int side2 = 4;
            int side3 = 4;

            //Act
            answer = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(answer, "The triangle cannot be formed");
        }

        /// <summary>
        /// Testing the Analyze method by giving all equal sides (3,3,3)
        /// To check if the triangle is Equilateral as expected
        /// The result will give: The triangle can be formed and is Equilateral
        /// </summary>
        [Test]
        public void AnalyzeMethod_GivenEqualSides_TriangleIsEquilateral()
        {
            //Arrange
            int side1 = 3;
            int side2 = 3;
            int side3 = 3;

            //Act
            string answer = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(answer, "The triangle can be formed\n" +
                "The triangle is Equilateral");
        }

        /// <summary>
        /// Testing the Analyze method by giving different sides (4,3,2)
        /// To check if the triangle is Scalene as expected
        /// The result will give: The triangle can be formed 
        /// and it's a Scalene Triangle
        /// </summary>
        [Test]
        public void AnalyzeMethod_GivenDifferentSides_TriangleIsScalene()
        {
            //Arrange
            int side1 = 4;
            int side2 = 3;
            int side3 = 2;

            //Act
            string answer = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(answer, "The triangle can be formed\n" +
                "The triangle is Scalene");
        }

        /// <summary>
        /// Testing the Analyze method by giving two equal sides (3,3,2)
        /// To check if the triangle is Isosceles
        /// The result will give: The triangle can be formed and is Isosceles 
        /// </summary>
        [Test]
        public void AnalyzeMethod_Given2EqualSides_TriangleIsIsosceles()
        {
            //Arrange
            int side1 = 3;
            int side2 = 3;
            int side3 = 2;
            
            //Act
            string answer = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(answer, "The triangle can be formed\n" +
                "The triangle is Isosceles");
        }

        /// <summary>
        /// Testing the Analyze method by giving a greater side (2,3,20)
        /// In which side1 + side2 > side3 will be false
        /// The result will give: The triangle cannot be formed
        /// </summary>
        [Test]
        public void AnalyzeMethod_GivenSides_TriangleCannotBeFormed()
        {
            //Arrange
            int side1 = 2;
            int side2 = 3;
            int side3 = 20;

            //Act
            string answer = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(answer, "The triangle cannot be formed");
        }

        /// <summary>
        /// Testing the Analyze method by giving sides 0 
        /// To check if the triangle can be formed or not
        /// The result will give: The triangle cannot be formed
        /// </summary>
        [Test]
        public void AnalyzeMethod_GivenSides0_TriangleCannotBeFormed()
        {
            //Arrange
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;

            //Act
            string answer = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(answer, "The triangle cannot be formed");
        }
    }
}
