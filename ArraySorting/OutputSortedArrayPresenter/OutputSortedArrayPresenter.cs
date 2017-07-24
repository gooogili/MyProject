using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraySorting.Model.Interfaces;
using ArraySorting.Views.Interfaces;
using ISorterNamespace;

namespace ArraySorting.Presenters
{
    public class OutputSortedArrayPresenter
    {
        public IOutputSortedArrayView view;
        public readonly IModel model;

        public List<ISorter> checkedSorters { get; set; }

        public OutputSortedArrayPresenter(IOutputSortedArrayView view, List<int> checkedSortersIndices)
        {
            this.view = view;
            model = Model.Model.GetModelInstance();

            checkedSorters = new List<ISorter>();

            CheckedSortersLoading(checkedSortersIndices);
        }

        public void CheckedSortersLoading(List<int> checkedSortersIndices)
        {
            model.SortersLoading();
            for (int i = 0; i < model.Sorters.Count; i++)
            {
                foreach (int checkedSorterIndex in checkedSortersIndices)
                {
                    if (i == checkedSorterIndex)
                    {
                        checkedSorters.Add(model.Sorters[checkedSorterIndex]);
                    }
                }
            }
        }

        public void ArrayFormContentLoading()
        {
            view.OutputArray(model.Array, model.LoadNamesOfSorters(checkedSorters));
        }

        public void StartSortingArray()
        {
            for (int sortersCounter = 0; sortersCounter < checkedSorters.Count; sortersCounter++)
            {
                checkedSorters[sortersCounter].ElementsAreSwapped += OnElementsSwapped;
            }
                int[] oneDimensionalArray = model.Convert2DArrayTo1D(model.Array);

            for (int i = 0; i < checkedSorters.Count; i++)
            {
                checkedSorters[i].Sort((int[])oneDimensionalArray.Clone());
            }
        }

        public void OnElementsSwapped(object sender, ElementsAreSwappedEventArgs e)
        {
            int numberOfRows = model.Array.GetLength(0);
            int numberOfColumns = model.Array.GetLength(1);
            int[,] array = model.Convert1DArrayTo2D(e.Array, numberOfRows, numberOfColumns);
            view.UpdateCurrentArray(array, e.FirstElement, e.SecondElement);
        }
    }
}
