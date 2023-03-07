using MegaPrimes.Interfaces;
using MegaPrimes.Models;

namespace MegaPrimes.Services
{
    public class MegaPrimeService : PrimeService, IMegaPrimeService
    {
        public bool IsMegaPrime(NumberModel candidateNumber)
        {
            // TODO:

            // exec
            if (!this.IsPrime(candidateNumber))
            {
                return false;
            }

            // We call a number megaprime if it is prime and all its individual digits are prime.
            throw new NotImplementedException();
        }
    }
}
