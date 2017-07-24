using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraySorting.Model.Interfaces;
using ArraySorting.Views.Interfaces;
using ArraySorting.Model;

namespace ArraySorting.Presenters
{
    public class MainMenuPresenter
    {
        public readonly IMainMenuView view;
        public readonly IModel model;

        public MainMenuPresenter(IMainMenuView view)
        {
            this.view = view;
            model = Model.Model.GetModelInstance();
        }

        public void OnMainMenuLoad()
        {
            model.SortersLoading();
            view.CreateSortersList(model.LoadNamesOfSorters(model.Sorters));
        }

        public void RandomGenerateArray(string numberOfRowsTextBox, string numberOfColumnsTextBox,
            string minArrayValueNumericUpDown, string maxArrayValueNumericUpDown)
        {
            int numberOfRows = Convert.ToInt32(numberOfRowsTextBox);
            int numberOfColumns = Convert.ToInt32(numberOfColumnsTextBox);
            int minArrayValue = Convert.ToInt32(minArrayValueNumericUpDown);
            int maxArrayValue = Convert.ToInt32(maxArrayValueNumericUpDown);            

            model.RandomArrayGenerate(numberOfRows, numberOfColumns, minArrayValue, maxArrayValue);
        }

        public void ManuallyInputArray(string numberOfRowsTextBox, string numberOfColumnsTextBox, string enteredArrayTextBox)
        {
            int numberOfRows = Convert.ToInt32(numberOfRowsTextBox);
            int numberOfColumns = Convert.ToInt32(numberOfColumnsTextBox);

            model.ManuallyInputAray(numberOfRows, numberOfColumns, enteredArrayTextBox);
        }
    }


}
