namespace MegaPrimes.Interfaces
{
    public interface IMegaPrimeService
    {
        IList<int> Primes { get; }
        bool IsMegaPrime(int candidateNumber);
    }
}