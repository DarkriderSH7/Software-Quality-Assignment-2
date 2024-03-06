using NUnit.Framework;

namespace TriangleSolver
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AnalyzeTriangle_InputIsEquilateral_ReturnsEquilateral()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("Equilateral triangle"));
        }

        [Test]
        public void AnalyzeTriangle_Sides5And5And3_IsIsosceles()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_Sides10And10And2_IsIsosceles()
        {
            // Arrange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 2;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_Sides8And4And8_IsIsosceles()
        {
            // Arrange
            int firstSide = 8;
            int secondSide = 4;
            int thirdSide = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }
    }
}