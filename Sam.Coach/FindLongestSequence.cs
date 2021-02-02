using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sam.Coach
{
    public  class FindLongestSequence
    {
        private readonly ILongestRisingSequenceFinder _longestRisingSequenceFinder;
        public  FindLongestSequence(ILongestRisingSequenceFinder longestRisingSequenceFinder)
        {
            _longestRisingSequenceFinder = longestRisingSequenceFinder;
        }

        public async Task<int[]> Find(IEnumerable<int>data)
        {
            var finder = await _longestRisingSequenceFinder.Find(data);
            return finder;
        }
    }
}
