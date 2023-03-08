namespace MegaPrimes.Models
{
    /// <summary>
    /// The candidate number model.
    /// </summary>
    public class NumberModel
    {
        /// <summary>
        /// The candidate number model.
        /// </summary>
        /// <param name="maximumIntegerValue">The candidate number maximum unsigned integer value.</param>
        public NumberModel(uint maximumIntegerValue)
        {
            MaximumIntegerValue = (int)maximumIntegerValue;
        }

        /// <summary>
        /// The candidate number maximum integer value.
        /// </summary>
        public int MaximumIntegerValue
        {
            get;
            private set;
        }
    }
}