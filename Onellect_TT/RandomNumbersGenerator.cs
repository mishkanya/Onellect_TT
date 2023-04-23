using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onellect_TT
{
    public class RandomNumbersGenerator
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public int MinCount { get; set; }
        public int MaxCount { get; set; }

        private Random _random = new Random();

        public RandomNumbersGenerator()
        {
            Validate();
        }

        public IEnumerable<int> GetRandomNumbersList()
        {
            var randomNumbersCount = _random.Next(MinCount, MaxCount);
            var randomNumbers = new List<int>();
            for (int i = 0; i < randomNumbersCount; i++)
            {
                randomNumbers.Add(_random.Next(MinValue, MaxValue));
            }
            return randomNumbers;
        }
        private void Validate()
        {
            if (MinValue > MaxValue) throw new ArgumentOutOfRangeException("MinValue", "MinValue must be more than MaxValue");
            if (MinCount < 0) throw new ArgumentOutOfRangeException("MinCount", "Count must be more then zero");
            if (MinCount > MaxValue) throw new ArgumentOutOfRangeException("MinCount", "MinCount must be more than MaxCount");
        }
    }
}
