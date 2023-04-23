using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onellect_TT.Sorters
{
    public class SelectionSorter : ISorter
    {
        public string SortMethodName { get => "Selection sort"; }

        public IEnumerable<int> Sort(IEnumerable<int> nubersToSort)
        {
            var numbersArray = nubersToSort.ToArray();
            var numbersCount = nubersToSort.Count();

            for (int i = 0; i < numbersCount - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < numbersCount; j++)
                {
                    if (numbersArray[j] < numbersArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = numbersArray[smallestVal];
                numbersArray[smallestVal] = numbersArray[i];
                numbersArray[i] = tempVar;
            }

            return numbersArray;
        }
    }
}