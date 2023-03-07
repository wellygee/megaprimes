
using MegaPrimes.Models;

namespace MegaPrimes.Interfaces
{
    public interface IMegaPrimeService
    {
        bool IsMegaPrime(NumberModel candidateNumber);
    }
}