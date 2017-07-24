using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomArrayCreator;
using System.Threading;
using ISorterNamespace;
using ManuallyInputtingArrayCreator;
using LoadingArrayFromDataBase;
using ArraySorting.Presenters;
using ArraySorting.Model.Interfaces;
using ArraySorting.Views.Interfaces;
using ArraySorting.Model;

namespace ArraySorting
{
    public partial class MainMenuForm : Form, IMainMenuView
    {
        private MainMenuPresenter presenter;
        private IModel model;

        public bool secondFormWasClosed = true;
        int numberOfRows;
        int numberOfColumns;

        public List<int> checkedSorters = new List<int>();

        public int[,] twoDimensionalArray;

        public MainMenuForm()
        {
            InitializeComponent();
            KeyPreview = true;
            model = Model.Model.GetModelInstance();
            presenter = new MainMenuPresenter(this);
        }

        private void randomArrayGenerateButton_Click(object sender, EventArgs e)
        {
            mainMenuTabControl.SelectedTab = mainMenuTabControl.TabPages["randomGenerationArrayTabPage"];
            Button previousPageButton = new Button();
            previousPageButton.Text = "< Main menu";
            previousPageButton.Location = new Point(15, 200);
            previousPageButton.Width = 100;
            mainMenuTabControl.SelectedTab.Controls.Add(previousPageButton);
            previousPageButton.Click += new EventHandler(previousPageButton_Click);
        }

        private void fromKeyboardInputArrayButton_Click(object sender, EventArgs e)
        {
            mainMenuTabControl.SelectedTab = mainMenuTabControl.TabPages["manuallyInputtingArrayTabPage"];
            Button previousPageButton = new Button();
            previousPageButton.Text = "< Main menu";
            previousPageButton.Location = new Point(15, 200);
            previousPageButton.Width = 100;
            mainMenuTabControl.SelectedTab.Controls.Add(previousPageButton);
            previousPageButton.Click += new EventHandler(previousPageButton_Click);
        }

        private void previousPageButton_Click(object sender, EventArgs e)
        {
            mainMenuTabControl.SelectedTab = mainMenuTabControl.TabPages["selectMethodForGettingAnArrayTabPage"];
        }

        public void CreateSortersList(List<string> namesOfSortersList)
        {
            foreach (var nameOfSorter in namesOfSortersList)
            {
                selectSortersCheckedListBox.Items.Add(nameOfSorter);
            }
            selectSortersCheckedListBox.MultiColumn = true;
            selectSortersCheckedListBox.SetItemChecked(0, true);
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");
            ChangeLanguage.Instance.localizeForm(this, cultureInfo);

            presenter.OnMainMenuLoad();

            selectLanguageToolStripComboBox.Text = CultureInfo.GetCultureInfo("en-US").EnglishName.ToString();
            selectLanguageToolStripComboBox.Items.Add(CultureInfo.GetCultureInfo("en-US").EnglishName.ToString());
            selectLanguageToolStripComboBox.Items.Add(CultureInfo.GetCultureInfo("uk-UA").EnglishName.ToString());
            selectLanguageToolStripComboBox.Items.Add(CultureInfo.GetCultureInfo("ru-RU").EnglishName.ToString());
        }

        private void confirmForRandomArrayButton_Click(object sender, EventArgs e)
        {

            presenter.RandomGenerateArray(numberOfRowsTextBox.Text, numberOfColumnsTextBox.Text,
                minArrayValueNumericUpDown.Value.ToString(), maxArrayValueNumericUpDown.Value.ToString());

            checkedSorters.Clear();

            foreach (var checkedSorterIndex in selectSortersCheckedListBox.CheckedIndices)
            {
                checkedSorters.Add((int)checkedSorterIndex);
            }

            if (checkedSorters.Count != 0)
            {
                OutputSortedArrayForm outputSortedArrayForm = new OutputSortedArrayForm(checkedSorters);
                outputSortedArrayForm.ShowDialog();
                //outputSortedArrayForm.OutputArray(twoDimensionalArray, numberOfRows, numberOfColumns, checkedSorters);
                //if (secondFormWasClosed == true)
                //{
                //    outputSortedArrayForm.Show();
                //}
                //else
                //{
                //    MessageBox.Show("This Form has already been created before.\nYou can not create more than one form");
                //}
            }
            else
            {
                MessageBox.Show("Please, select one or more sorting methods");
            }


            //if ((numberOfRowsTextBox.Text != "") && (numberOfColumnsTextBox.Text != ""))
            //{
            //    if (int.TryParse(numberOfRowsTextBox.Text, out numberOfRows))
            //    {
            //        if (int.TryParse(numberOfColumnsTextBox.Text, out numberOfColumns))
            //        {
            //            RandomCreator randomArrayCreator = new RandomCreator();
            //            twoDimensionalArray = randomArrayCreator.RandomGeneration(numberOfRows, numberOfColumns, (int)minArrayValueNumericUpDown.Value, (int)maxArrayValueNumericUpDown.Value);

            //            DllHunter dllFinder = new DllHunter();
            //            List<ISorter> sorters = new List<ISorter>();
            //            sorters = dllFinder.FindDll();

            //            checkedSorters.Clear();

            //            foreach (var checkedSorter in selectSortersCheckedListBox.CheckedIndices)
            //            {
            //                checkedSorters.Add(sorters[(int)checkedSorter]);
            //            }

            //            foreach (Form openForm in Application.OpenForms)
            //                if (openForm.Name == "OutputSortedArrayForm")
            //                {
            //                    secondFormWasClosed = false;
            //                }

            //            if (checkedSorters.Count != 0)
            //            {
            //                OutputSortedArrayForm outputSortedArrayForm = new OutputSortedArrayForm();
            //                outputSortedArrayForm.OutputArray(twoDimensionalArray, numberOfRows, numberOfColumns, checkedSorters);
            //                if (secondFormWasClosed == true)
            //                {
            //                    outputSortedArrayForm.Show();
            //                }
            //                //else
            //                //{
            //                //    MessageBox.Show("This Form has already been created before.\nYou can not create more than one form");
            //                //}
            //            }
            //            else
            //            {
            //                MessageBox.Show("Please, select one or more sorting methods");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error2");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error1");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Fields are empty");
            //}
        }



        private void selectLanguageToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("uk-UA");
            if (selectLanguageToolStripComboBox.SelectedIndex == 0)
            {
                cultureInfo = new CultureInfo("en-US");
            }
            else if (selectLanguageToolStripComboBox.SelectedIndex == 1)
            {
                cultureInfo = new CultureInfo("uk-UA");
            }
            else if (selectLanguageToolStripComboBox.SelectedIndex == 2)
            {
                cultureInfo = new CultureInfo("ru-RU");
            }
            ChangeLanguage.Instance.localizeForm(this, cultureInfo);
        }


        private void confirmForManuallyInputingButton_Click(object sender, EventArgs e)
        {


            //if ((numberOfRowsInManuallyTextBox.Text != "") && (numberOfColumnsInManuallyTextBox.Text != "")
            //    && (fieldForArrayTextBox.Text != ""))
            //{
            //    if (int.TryParse(numberOfRowsInManuallyTextBox.Text, out numberOfRows))
            //    {
            //        if (int.TryParse(numberOfColumnsInManuallyTextBox.Text, out numberOfColumns))
            //        {
            //            ManuallyInputtingArray manuallyInputtingArray = new ManuallyInputtingArray();
            //            twoDimensionalArray = manuallyInputtingArray.ManuallyInputting(numberOfRows, numberOfColumns,
            //                fieldForArrayTextBox.Text);

            //            DllHunter dllFinder = new DllHunter();
            //            List<ISorter> sorters = new List<ISorter>();
            //            sorters = dllFinder.FindDll();

            //            checkedSorters.Clear();

            //            foreach (var checkedSorter in selectSortersCheckedListBox.CheckedIndices)
            //            {
            //                checkedSorters.Add(sorters[(int)checkedSorter]);
            //            }

            //            foreach (Form openForm in Application.OpenForms)
            //                if (openForm.Name == "OutputSortedArrayForm")
            //                {
            //                    secondFormWasClosed = false;
            //                }

            //            if (checkedSorters.Count != 0)
            //            {
            //                OutputSortedArrayForm outputSortedArrayForm = new OutputSortedArrayForm();
            //                outputSortedArrayForm.OutputArray(twoDimensionalArray, numberOfRows, numberOfColumns,
            //                    checkedSorters);

            //                if (secondFormWasClosed == true)
            //                {
            //                    outputSortedArrayForm.Show();
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Please, select one or more sorting methods");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Please, input right number of columns");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please, input right number of rows");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Fields are empty");
            //}
        }

        int arraySize = 0;

        private void numberOfColumnsInManuallyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberOfRowsInManuallyTextBox.Text, out numberOfRows))
            {
                if (int.TryParse(numberOfColumnsInManuallyTextBox.Text, out numberOfColumns))
                {
                    arraySize = numberOfColumns * numberOfRows;
                    label1.Text = arraySize + " numbers left";
                }
            }
        }

        private void fieldForArrayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)32)
            {
                //e.Handled = true;
                arraySize--;
                label1.Text = arraySize + " numbers left";
            }
        }


        private void fromDataBaseArrayLoadingButton_Click(object sender, EventArgs e)
        {
            //LoadingFromDataBase loadArrayFromDB = new LoadingFromDataBase();
            //twoDimensionalArray = loadArrayFromDB.DBReader();

            //DllHunter dllFinder = new DllHunter();
            //List<ISorter> sorters = new List<ISorter>();
            //sorters = dllFinder.FindDll();

            //checkedSorters.Clear();

            //foreach (var checkedSorter in selectSortersCheckedListBox.CheckedIndices)
            //{
            //    checkedSorters.Add(sorters[(int)checkedSorter]);
            //}

            //foreach (Form openForm in Application.OpenForms)
            //    if (openForm.Name == "OutputSortedArrayForm")
            //    {
            //        secondFormWasClosed = false;
            //    }

            //if (checkedSorters.Count != 0)
            //{
            //    OutputSortedArrayForm outputSortedArrayForm = new OutputSortedArrayForm();
            //    outputSortedArrayForm.OutputArray(twoDimensionalArray, loadArrayFromDB.rows, loadArrayFromDB.columns,
            //        checkedSorters);

            //    if (secondFormWasClosed == true)
            //    {
            //        outputSortedArrayForm.Show();
            //    }
            //    //else
            //    //{
            //    //    MessageBox.Show("This Form has already been created before.\nYou can not create more than one form");
            //    //}
            //}
            //else
            //{
            //    MessageBox.Show("Please, select one or more sorting methods");
            //}
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Languages.Lang.exitConfirmText, "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
