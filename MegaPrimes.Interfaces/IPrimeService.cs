
using MegaPrimes.Models;

namespace MegaPrimes.Interfaces
{
    public interface IPrimeService
    {
        bool IsPrime(NumberModel candidateNumber);
    }
}