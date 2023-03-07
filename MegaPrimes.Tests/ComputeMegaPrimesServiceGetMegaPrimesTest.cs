using MegaPrimes.Interfaces;
using MegaPrimes.Models;
using MegaPrimes.Services;
using NUnit.Framework;

namespace MegaPrimes.Tests
{
    [TestFixture]
    public class ComputeMegaPrimesServiceGetMegaPrimesTest
    {
        private IMegaPrimeService _megaPrimeService;
        private IComputeMegaPrimesService _computeMegaPrimesService;

        [SetUp]
        public void Setup()
        {
            _megaPrimeService = new MegaPrimeService();
            _computeMegaPrimesService = new ComputeMegaPrimesService(_megaPrimeService);
        }

        [Test, Category("PrimeService > IsPrime")]
        public void IsPrime_When_Input_Is_Null_Should_Return_Invalid_Input_Error()
        {
            // Arrange
            NumberModel numberModelNullTestValue = null;

            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => _computeMegaPrimesService.GetMegaPrimes(numberModelNullTestValue));
        }

        [Test, Category("PrimeService > IsMegaPrime")]
        [TestCase(10, ExpectedResult = "[2,3,4,5]")]
        [TestCase(37, ExpectedResult = "[2,3,5,7,23,37]")]
        public string IsPrime_When_Input_Valid_Should_Return_True(int candidateNumber)
        {
            var candidateNumberModel = new NumberModel(candidateNumber);
            return _computeMegaPrimesService.GetMegaPrimes(candidateNumberModel);
        }

        [Test, Category("PrimeService > IsMegaPrime")]
        [TestCase(1, ExpectedResult = "[]")]
        public string IsPrime_When_Input_Valid_Should_Return_False(int candidateNumber)
        {
            var candidateNumberModel = new NumberModel(candidateNumber);
            return _computeMegaPrimesService.GetMegaPrimes(candidateNumberModel);
        }
    }
}