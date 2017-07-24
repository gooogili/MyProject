using ISorterNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySorting
{
    interface IOutputSortedArrayView
    {

    }

    public partial class OutputSortedArrayForm : Form, IOutputSortedArrayView
    {
        public List<ISorter> checkedSorters = new List<ISorter>();
        int[] oneDimensionalArray;
        int rows, columns;
        private object threadLock = new object();

        public OutputSortedArrayForm()
        {
            InitializeComponent();
        }

        private void OutputSortedArrayForm_Load(object sender, EventArgs e)
        {

        }

        public void OutputArray(int[,] twoDimensionalArray, int rows, int columns, List<ISorter> sorters)
        {
            int a = 0;
            checkedSorters = sorters;
            this.rows = rows;
            this.columns = columns;
            arraysShowTabControl.TabPages.Clear();

            foreach (var sorter in checkedSorters)
            {
                TabPage page = new TabPage(sorter.methodName);
                arraysShowTabControl.TabPages.Add(page);
                a++;

                DataGridView newDataGridView = new DataGridView();
                newDataGridView.Dock = DockStyle.Fill;
                page.Controls.Add(newDataGridView);
                newDataGridView.ReadOnly = true;
                newDataGridView.RowHeadersVisible = false;
                newDataGridView.ColumnHeadersVisible = false;
                newDataGridView.RowCount = rows;
                newDataGridView.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        newDataGridView.Rows[i].Cells[j].Value = twoDimensionalArray[i, j];
                    }
                }
                oneDimensionalArray = twoDimensionalArray.Cast<int>().ToArray();
            }
        }

        private void sortingArraysSpeedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            foreach (var item in checkedSorters)
            {
                item.speedChanger = sortingArraysSpeedTrackBar.Value;
            }
        }

        private void startSortingButton_Click(object sender, EventArgs e)
        {
            DataGridView selectedDataGridView = (DataGridView)arraysShowTabControl.SelectedTab.GetNextControl(ActiveControl, true);
            int[] sortedArray = oneDimensionalArray;
            int index = arraysShowTabControl.SelectedIndex;
            Thread thread = new Thread(() =>
            {
                lock (threadLock)
                {
                    sortedArray = checkedSorters[index].Sort((int[])oneDimensionalArray.Clone());

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            selectedDataGridView.Rows[i].Cells[j].Value = sortedArray[i * columns + j];
                            selectedDataGridView.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                            //selectedDataGridView.Refresh();
                        }
                    }
                    MessageBox.Show(checkedSorters[index].methodTime.ToString() + " sec.");
                }
            });
            thread.Start();

        }
    }
}
