using MegaPrimes.Interfaces;

namespace MegaPrimes.Services
{
    public class PrimeService : IPrimeService
    {
        public bool IsPrime(int candidateNumber)
        {
            if (candidateNumber <= 1) return false;
            if (candidateNumber == 2 || candidateNumber == 3) return true;
            if (candidateNumber % 2 == 0) return false;

            var candidateNumberUpperBound = (int)Math.Floor(Math.Sqrt(candidateNumber));

            for (int number = 3; number <= candidateNumberUpperBound; number += 2)
            {
                if (candidateNumber % number == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}