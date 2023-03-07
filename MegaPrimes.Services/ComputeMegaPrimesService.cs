using MegaPrimes.Interfaces;
using MegaPrimes.Models;

namespace MegaPrimes.Services
{
    public class ComputeMegaPrimesService : IComputeMegaPrimesService
    {
        private readonly IMegaPrimeService _megaPrimeService;

        public ComputeMegaPrimesService(IMegaPrimeService megaPrimeService)
        {
            _megaPrimeService = megaPrimeService;
        }

        public string GetMegaPrimes(NumberModel candidateNumberModel)
        {
            return _megaPrimeService.IsMegaPrime(candidateNumberModel.MaximumIntegerValue)
                    ? $"[{string.Join(',', _megaPrimeService.Primes)}]"
                    : "[]";
        }
    }
}
