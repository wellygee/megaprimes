using MegaPrimes.Interfaces;
using MegaPrimes.Services;
using NUnit.Framework;

namespace MegaPrimes.Tests
{
    [TestFixture]
    public class PrimeServiceIsPrimeTest
    {
        private IPrimeService _primeService;

        [SetUp]
        public void Setup()
        {
            _primeService = new PrimeService();
        }

        // Arrange
        // Act
        // Assert

        [Test, Category("PrimeService > IsPrime")]
        [TestCase(-1, ExpectedResult = false)]
        [TestCase(0, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = false)]
        public bool IsPrime_When_Input_Is_Less_Than1_Should_Return_False(int candidateNumber)
        {
            return _primeService.IsPrime(candidateNumber);
        }

        [Test, Category("PrimeService > IsPrime")]
        [TestCase(3, ExpectedResult = true)]
        [TestCase(13, ExpectedResult = true)]
        [TestCase(53, ExpectedResult = true)]
        public bool IsPrime_When_Input_Valid_Should_Return_True(int candidateNumber)
        {
            return _primeService.IsPrime(candidateNumber);
        }

        [Test, Category("PrimeService > IsPrime")]
        [TestCase(4, ExpectedResult = false)]
        [TestCase(6, ExpectedResult = false)]
        [TestCase(35, ExpectedResult = false)]
        public bool IsPrime_When_Input_Valid_Should_Return_False(int candidateNumber)
        {
            return _primeService.IsPrime(candidateNumber);
        }
    }
}