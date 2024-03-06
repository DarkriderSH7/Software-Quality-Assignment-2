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
            [Test]
            public void AnalyzeTriangle_Sides3And4And5_IsScalene()
            {
                // Arrange
                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 5;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_Sides5And7And10_IsScalene()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 7;
                int thirdSide = 10;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_Sides6And8And10_IsScalene()
            {
                // Arrange
                int firstSide = 6;
                int secondSide = 8;
                int thirdSide = 10;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_Sides9And12And15_IsScalene()
            {
                // Arrange
                int firstSide = 9;
                int secondSide = 12;
                int thirdSide = 15;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_Sides5And12And13_IsScalene()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 12;
                int thirdSide = 13;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Scalene triangle"));
            }

            [Test]
            public void AnalyzeTriangle_SideZero_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 0;
                int secondSide = 7;
                int thirdSide = 10;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
            }

            [Test]
            public void AnalyzeTriangle_TwoSidesZero_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 10;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
            }

            [Test]
            public void AnalyzeTriangle_AllSidesZero_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 0;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
            }

            [Test]
            public void AnalyzeTriangle_SidesDoNotFormTriangle_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 1;
                int secondSide = 2;
                int thirdSide = 3;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("INVALID!!"));
            }

            [Test]
            public void AnalyzeTriangle_SidesNegative_ReturnsInvalid()
            {
                // Arrange
                int firstSide = -1;
                int secondSide = 2;
                int thirdSide = 3;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("INVALID!!"));
            }

            [Test]
            public void AnalyzeTriangle_SumOfTwoSidesEqualToThird_ReturnsInvalid()
            {
                // Arrange
                int firstSide = 3;
                int secondSide = 3;
                int thirdSide = 6;

                // Act
                string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                Assert.That(result, Is.EqualTo("INVALID!!"));
            }
        }
    }
