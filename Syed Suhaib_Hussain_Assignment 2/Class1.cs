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

        
    }
}
