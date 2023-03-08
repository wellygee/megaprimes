namespace MegaPrimes.Interfaces
{
    /// <summary>
    /// The IPrimeService interface.
    /// </summary>
    public interface IPrimeService
    {
        /// <summary>
        /// The IsPrime method. Checks whether or not a given integer input is a prime number
        /// </summary>
        /// <param name="candidateNumber" cref="Int32">The input number</param>
        /// <returns cref="Boolean">A boolean value.
        /// True when <paramref name="candidateNumber"/> is a prime number, False otherwise.
        /// </returns>
        bool IsPrime(int candidateNumber);
    }
}