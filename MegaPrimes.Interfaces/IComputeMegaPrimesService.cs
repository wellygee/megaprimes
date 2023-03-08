using MegaPrimes.Models;

namespace MegaPrimes.Interfaces
{
    /// <summary>
    /// The IComputeMegaPrimesService interface.
    /// Encapsulates the business logic for computing megaprimes.
    /// </summary>
    public interface IComputeMegaPrimesService
    {
        /// <summary>
        /// Identifies the collection of megaprimes given a maximum unsigned integer value.
        /// </summary>
        /// <param name="candidateNumberModel" cref="NumberModel">
        /// The input model.
        /// </param>
        /// <returns cref="IEnumerable<UInt32>">A formated string of 32-bit unsigned integers, the collection of 
        /// megaprimes from 1 to max inclusive.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// When <paramref name="candidateNumberModel"/> is null.
        /// </exception>
        IEnumerable<uint> GetMegaPrimes(NumberModel candidateNumberModel);
    }
}
