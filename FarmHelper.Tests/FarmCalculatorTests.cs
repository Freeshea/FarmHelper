using NUnit.Framework;
using FarmHelper.Model;

namespace FarmHelper.Tests
{
    public class Tests
    {
        private FarmCalculator calculator;


        [SetUp]
        public void Setup()
        {
            calculator = new FarmCalculator(2, 12); // Initializing with default drop chance and mob count
        }

        [Test]
        public void CalculateProbability_WithOneRun_ShouldReturnExpectedProbability()
        {
            // Arrange
            int runCount = 1;
            double expectedProbability = 0.21528;

            // Act
            double result = calculator.CalculateProbability(runCount);

            // Assert
            Assert.That(result, Is.EqualTo(expectedProbability).Within(0.0001), "The probability calculation is incorrect for one run.");
        }

        [Test]
        public void CalculateRequiredRuns_With90PercentTarget_ShouldReturnExpectedRunCount()
        {
            // Arrange
            double targetProbability = 0.90;
            double expectedRuns = 10;

            // Act
            int requiredRuns = calculator.CalculateRequiredRuns(targetProbability);

            // Assert
            Assert.That(requiredRuns, Is.EqualTo(expectedRuns), "The required runs for 90% probability calculation is incorrect.");
        }

        [Test]
        public void CalculateProbability_NegativeRunCount_ShouldReturnZero()
        {
            // Act
            double result = calculator.CalculateProbability(-1);
            double expectedProbability = 0;

            // Assert
            Assert.That(result, Is.EqualTo(expectedProbability), "The probability calculation should return 0 for a negative run count.");
        }
    }
}