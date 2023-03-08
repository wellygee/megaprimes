namespace MegaPrimes.Interfaces
{
    /// <summary>
    /// The IMegaPrimeService interface.
    /// </summary>
    public interface IMegaPrimeService
    {
        /// <summary>
        /// Returns true if a given integer number is a megaprimme.
        /// </summary>
        /// <param name="candidateNumber" cref="Int32">The candidate number.</param>
        /// <returns cref="Boolean">True is a given integer number is a megaprime, False otherwise.</returns>
        bool IsMegaPrime(int candidateNumber);

    }
}