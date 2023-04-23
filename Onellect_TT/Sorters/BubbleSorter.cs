using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onellect_TT.Sorters
{
    public class BubbleSorter : ISorter
    {
        public string SortMethodName { get => "Bubble sort"; }

        public IEnumerable<int> Sort(IEnumerable<int> nubersToSort)
        {
            var numbersArray = nubersToSort.ToArray();
            var numbersCount = nubersToSort.Count();
            bool swapRequired;

            for (int i = 0; i < numbersCount - 1; i++)
            {
                swapRequired = false;
                for (int j = 0; j < numbersCount - i - 1; j++)
                    if (numbersArray[j] > numbersArray[j + 1])
                    {
                        var tempVar = numbersArray[j];
                        numbersArray[j] = numbersArray[j + 1];
                        numbersArray[j + 1] = tempVar;
                        swapRequired = true;
                    }
                if (swapRequired == false)
                    break;
            }


            return numbersArray;
        }
    }
}
