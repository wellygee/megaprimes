using MegaPrimes.Interfaces;

namespace MegaPrimes.Services
{
    public class MegaPrimeService : PrimeService, IMegaPrimeService
    {
        public bool IsMegaPrime(int candidateNumber)
        {
            bool isMegaPrimeResult = false;

            if (!this.IsPrime(candidateNumber))
            {
                return isMegaPrimeResult;
            }

            if (IsAllDigitsPrime(candidateNumber))
            {
                isMegaPrimeResult = true;
            }

            return isMegaPrimeResult;
        }

        private bool IsAllDigitsPrime(int primeNumber)
        {
            string digits = primeNumber.ToString();

            foreach (char digit in digits)
            {
                int parsedDigit = int.Parse(digit.ToString());
                if (!this.IsPrime(parsedDigit))
                {
                    return false;
                }
            }

            return true;
        }
    }
}


