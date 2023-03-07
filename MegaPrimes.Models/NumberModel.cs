namespace MegaPrimes.Models
{
    public class NumberModel
    {
        public NumberModel(int candidateNumber)
        {
            CandidateNumber = candidateNumber;
        }
        public int CandidateNumber { get; set; }
    }
}