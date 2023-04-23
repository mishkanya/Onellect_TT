using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onellect_TT.Sorters
{
    public interface ISorter
    {
        public string SortMethodName { get; }
        IEnumerable<int> Sort(IEnumerable<int> nubersToSort);
    }
}
