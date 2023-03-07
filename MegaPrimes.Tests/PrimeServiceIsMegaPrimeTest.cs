using MegaPrimes.Interfaces;
using MegaPrimes.Services;
using NUnit.Framework;

namespace MegaPrimes.Tests
{
    [TestFixture]
    public class PrimeServiceIsMegaPrimeTest
    {
        private IMegaPrimeService _megaPrimeService;

        [SetUp]
        public void Setup()
        {
            _megaPrimeService = new MegaPrimeService();
        }

        [Test, Category("PrimeService > IsMegaPrime")]
        [TestCase(53, ExpectedResult = true)]
        [TestCase(23, ExpectedResult = true)]
        [TestCase(37, ExpectedResult = true)]
        public bool IsPrime_When_Input_Valid_Should_Return_True(int candidateNumber)
        {
            return _megaPrimeService.IsMegaPrime(candidateNumber);
        }

        [Test, Category("PrimeService > IsMegaPrime")]
        [TestCase(13, ExpectedResult = true)]
        [TestCase(31, ExpectedResult = true)]
        public bool IsPrime_When_Input_Valid_Should_Return_False(int candidateNumber)
        {
            return _megaPrimeService.IsMegaPrime(candidateNumber);
        }
    }
}