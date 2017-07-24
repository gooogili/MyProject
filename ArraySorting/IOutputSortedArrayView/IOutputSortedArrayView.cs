using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting.Views.Interfaces
{
    public interface IOutputSortedArrayView
    {
        void OutputArray(int[,] twoDimensionalArray, List<string> sortersName);
        void UpdateCurrentArray(int[,] array, int firstSwapElementIndex, int secondSwapElementIndex);
    }
}
