using ISorterNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting.Model.Interfaces
{
    public interface IModel
    {
        int[,] Array { get; set; }

        List<ISorter> Sorters { get; set; }
        List<string> namesOfSorters { get; set; }

        void SortersLoading();
        List<string> LoadNamesOfSorters(List<ISorter> sorters);
        void RandomArrayGenerate(int rows, int columns, int minArrayValue, int maxArrayValue);
        void ManuallyInputAray(int rows, int columns, string stringArray);
        void LoadArrayFromDB();
        int[] Convert2DArrayTo1D(int[,] twoDimensionalArray);
        int[,] Convert1DArrayTo2D(int[] oneDimensionalArray, int numberOfRows, int numberOfColumns);
        //void UploadSortedArrayToDB();
    }
}
