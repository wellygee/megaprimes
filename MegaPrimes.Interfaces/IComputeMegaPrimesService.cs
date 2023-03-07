using MegaPrimes.Models;

namespace MegaPrimes.Interfaces
{
    public interface IComputeMegaPrimesService
    {
        string GetMegaPrimes(NumberModel candidateNumberModel);
    }
}
