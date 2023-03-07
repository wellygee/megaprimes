namespace MegaPrimes.Models
{
    public class NumberModel
    {
        public NumberModel(int maximumIntegerValue)
        {
            MaximumIntegerValue = maximumIntegerValue;
        }
        public int MaximumIntegerValue { get; set; }
    }
}