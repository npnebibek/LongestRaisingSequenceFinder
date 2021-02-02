using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sam.Coach
{
    internal class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        public Task<int[]> Find(IEnumerable<int> numbers) => Task.Run(() =>
        {
            // TODO: return the longest raising sequence in the collection provided, i.e.
            // when numbers = [4, 6, -3, 3, 7, 9] then expected result is [-3, 3, 7, 9]
            // when numbers = [9, 6, 4, 5, 2, 0] then expected result is [4, 5]
            IComparer<int> comparer = Comparer<int>.Default;
            IList < int >values= numbers.ToList();
            var pileTops = new List<int>();
            var pileAssignments = new int[values.Count];
            for (int i = 0; i < values.Count; i++)
            {
                int element = values[i];
                int pile = pileTops.BinarySearch(element, comparer);
                if (pile < 0) pile = ~pile;
                if (pile == pileTops.Count) pileTops.Add(element);
                else pileTops[pile] = element;
                pileAssignments[i] = pile;
            }
            int[] result1 = new int[pileTops.Count];
            for (int i = pileAssignments.Length - 1, p = pileTops.Count - 1; p >= 0; i--)
            {
                if (pileAssignments[i] == p) result1[p--] = values[i];
            }
            return result1;
        });
    }
}
