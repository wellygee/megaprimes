using MegaPrimes.Interfaces;
using MegaPrimes.Models;

namespace MegaPrimes.Services
{
    public class ComputeMegaPrimesService : IComputeMegaPrimesService
    {
        private readonly IMegaPrimeService _megaPrimeService;

        private readonly IList<uint> _megaPrimes = new List<uint>();

        public ComputeMegaPrimesService(IMegaPrimeService megaPrimeService)
        {
            _megaPrimeService = megaPrimeService;
        }

        public IEnumerable<uint> GetMegaPrimes(NumberModel candidateNumberModel)
        {
            if (candidateNumberModel == null)
            {
                throw new ArgumentNullException(nameof(candidateNumberModel));
            }

            _megaPrimes.Clear();

            ComputeMegaPrimes(candidateNumberModel.MaximumIntegerValue);

            return _megaPrimes.OrderBy(mp => mp);
        }

        private void ComputeMegaPrimes(int maximumValue)
        {
            if (maximumValue < 2)
            {
                return;
            }

            if (_megaPrimeService.IsMegaPrime(maximumValue))
            {
                this._megaPrimes.Add((uint)maximumValue);
            }

            maximumValue--;
            ComputeMegaPrimes(maximumValue);
        }
    }
}

