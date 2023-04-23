using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onellect_TT.Sorters
{
    public class SortManager
    {
        private List<ISorter> _ISorters = new List<ISorter>();
        private Random _random = new Random();

        public SortManager()
        {
            SortersInitialize();
        }
        private void SortersInitialize()
        {
            _ISorters.Add(new BubbleSorter());
            _ISorters.Add(new SelectionSorter());
        }

        public ISorter GetRandomSorter()
        {
            var sorterIndex = _random.Next(0, _ISorters.Count);
            return _ISorters.ElementAt(sorterIndex);
        }
    }
}
