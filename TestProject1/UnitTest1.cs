using CalculationsAPI.Model;
using CalculationsAPI.Service;

namespace TestProject1
{
    public class Tests
    {
        private CalculationService calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new CalculationService();
        }

        [Test]
        public void TestAddition()
        {
            // Arrange
            var req = new RequestModel()
            {
                firstNum = 3,
                secondNum = 5
            };
            double expected = 8;

            // Act
            double result = calculator.Addition(req).Result.Answer;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestSubtraction()
        {
            // Arrange
            var req = new RequestModel()
            {
                firstNum = 5,
                secondNum = 3
            };
            double expected = 2;

            // Act
            double result = calculator.Subtraction(req).Result.Answer;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestMultiplication()
        {
            // Arrange
            var req = new RequestModel()
            {
                firstNum = 5,
                secondNum = 3
            };
            double expected = 15;

            // Act
            double result = calculator.Multiplication(req).Result.Answer;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestDivision()
        {
            // Arrange
            var req = new RequestModel()
            {
                firstNum = 10,
                secondNum = 2
            };
            double expected = 5;

            // Act
            double result = calculator.Division(req).Result.Answer;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestIsPrime_ForPrimeNumber_ReturnsTrue()
        {
            // Arrange
            double primeNumber = 7;

            // Act
            bool result = calculator.IsPrime(primeNumber).Result;

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void TestIsPrime_ForNonPrimeNumber_ReturnsFalse()
        {
            // Arrange
            double nonPrimeNumber = 10;

            // Act
            bool result = calculator.IsPrime(nonPrimeNumber).Result;

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void TestIsPrime_ForZero_ReturnsFalse()
        {
            // Arrange
            double zero = 0;

            // Act
            bool result = calculator.IsPrime(zero).Result;

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void TestIsPrime_ForOne_ReturnsFalse()
        {
            // Arrange
            double one = 1;

            // Act
            bool result = calculator.IsPrime(one).Result;

            // Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void TestIsOdd_ForOddNumber_ReturnsTrue()
        {
            // Arrange
            double oddNumber = 5;
            string colour = "";

            // Act
            bool result = calculator.IsEven(oddNumber,out colour);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void TestIsOdd_ForEvenNumber_ReturnsFalse()
        {
            // Arrange
            double evenNumber = 10;
            string colour = "";

            // Act
            bool result = calculator.IsEven(evenNumber,out colour);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void TestIsEven_ForEvenNumber_ReturnsTrue()
        {
            // Arrange
            double evenNumber = 10;
            string colour = "";
            // Act
            bool result = calculator.IsEven(evenNumber, out colour);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void TestIsEven_ForOddNumber_ReturnsFalse()
        {
            // Arrange
            double oddNumber = 5;
            string colour = "";

            // Act
            bool result = calculator.IsEven(oddNumber, out colour);

            // Assert
            Assert.IsFalse(result);
        }

    }
}