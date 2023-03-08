using MegaPrimes.Interfaces;
using MegaPrimes.Models;
using MegaPrimes.Services;

namespace MegaPrimes.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMegaPrimeService _megaPrimeService = new MegaPrimeService();
            IComputeMegaPrimesService _computeMegaPrimesService = new ComputeMegaPrimesService(_megaPrimeService);

            var result1 = _computeMegaPrimesService.GetMegaPrimes(new NumberModel(10));
            DisplayFormattedResult("Example 1", result1);

            var result2 = _computeMegaPrimesService.GetMegaPrimes(new NumberModel(37));
            DisplayFormattedResult("Example 2", result2);

            var result3 = _computeMegaPrimesService.GetMegaPrimes(new NumberModel(1));
            DisplayFormattedResult("Example 3", result3);

            Console.ReadLine();
        }

        private static void DisplayFormattedResult(string exampleNumber, IEnumerable<uint> megaPrimes)
        {
            Console.WriteLine(exampleNumber);
            Console.WriteLine($"[{string.Join(',', megaPrimes)}]");
            Console.WriteLine();
        }
    }
}
