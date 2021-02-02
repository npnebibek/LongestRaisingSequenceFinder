using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sam.Coach
{
    public interface ILongestRisingSequenceFinder {
        Task<int[]> Find(IEnumerable<int> numbers);
    }
}