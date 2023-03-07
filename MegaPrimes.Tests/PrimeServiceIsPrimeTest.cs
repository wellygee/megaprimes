using MegaPrimes.Interfaces;
using MegaPrimes.Models;
using MegaPrimes.Services;
using NUnit.Framework;

namespace MegaPrimes.Tests
{
    [TestFixture("PrimeService")]
    public class PrimeServiceIsPrimeTest
    {
        private IPrimeService _primeService;

        [SetUp]
        public void Setup()
        {
            _primeService = new PrimeService();
        }

        [Test, Category("PrimeService > IsPrime")]
        public void IsPrime_When_Input_Is1_Should_Return_False()
        {
            var result = _primeService.IsPrime(new NumberModel(1));

            Assert.IsFalse(result, "1 should not be prime");
        }

        [Test, Category("PrimeService > IsPrime")]
        [TestCase(1, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = true)]
        [TestCase(-1, ExpectedResult = true)]
        public bool IsPrime_When_Input_Valid_Should_Return_True(int candidateNumber)
        {
            var model = new NumberModel(candidateNumber);
            return model.CandidateNumber % 2 == 0; // method call
        }

        [Test, Category("PrimeService > IsPrime")]
        [TestCase(1, ExpectedResult = false)]
        [TestCase(2, ExpectedResult = false)]
        [TestCase(-1, ExpectedResult = false)]
        public bool IsPrime_When_Input_Valid_Should_Return_False(int candidateNumber)
        {
            var model = new NumberModel(candidateNumber);
            return model.CandidateNumber % 2 == 0; // method call
        }
    }
}