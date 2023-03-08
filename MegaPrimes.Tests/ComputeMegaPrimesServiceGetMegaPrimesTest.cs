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

        [Test, Category("PrimeService > GetMegaPrimes")]
        public void GetMegaPrimes_When_Input_Is_Null_Should_Return_Invalid_Input_Error()
        {
            // Arrange
            NumberModel numberModelNullTestValue = null;

            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => _computeMegaPrimesService.GetMegaPrimes(numberModelNullTestValue));
        }

        [Test, Category("PrimeService > GetMegaPrimes")]
        [TestCase(0u, ExpectedResult = new uint[] { })]
        [TestCase(1u, ExpectedResult = new uint[] { })]
        public uint[] GetMegaPrimes_When_Non_MegaPrime_Input_supplied_Should_Return_Empty_Collection(uint candidateNumber)
        {
            var candidateNumberModel = new NumberModel(candidateNumber);
            return _computeMegaPrimesService.GetMegaPrimes(candidateNumberModel).ToArray();
        }

        [Test, Category("PrimeService > GetMegaPrimes")]
        [TestCase(3u, ExpectedResult = new uint[] { 2, 3 })]
        [TestCase(10u, ExpectedResult = new uint[] { 2, 3, 5, 7 })]
        [TestCase(13u, ExpectedResult = new uint[] { 2, 3, 5, 7 })]
        [TestCase(35u, ExpectedResult = new uint[] { 2, 3, 5, 7, 23 })]
        [TestCase(37u, ExpectedResult = new uint[] { 2, 3, 5, 7, 23, 37 })]
        [TestCase(53u, ExpectedResult = new uint[] { 2, 3, 5, 7, 23, 37, 53 })]
        public uint[] GetMegaPrimes_When_Input_Valid_Should_Return_Correct_Collection(uint candidateNumber)
        {
            var candidateNumberModel = new NumberModel(candidateNumber);
            return _computeMegaPrimesService.GetMegaPrimes(candidateNumberModel).ToArray();
        }
    }
}
