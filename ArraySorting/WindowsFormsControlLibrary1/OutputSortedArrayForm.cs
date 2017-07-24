using ArraySorting.Presenters;
using ArraySorting.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArraySorting
{
    public partial class OutputSortedArrayForm : Form, IOutputSortedArrayView
    {
        public readonly OutputSortedArrayPresenter presenter;
        
        private object threadLock = new object();

        public OutputSortedArrayForm(List<int> checkedSorters)
        {
            InitializeComponent();
            presenter = new OutputSortedArrayPresenter(this, checkedSorters);
            presenter.ArrayFormContentLoading();
        }

        private void OutputSortedArrayForm_Load(object sender, EventArgs e)
        {

        }

        public void OutputArray(int[,] twoDimensionalArray, List<string> sortersName)
        {
            arraysShowTabControl.TabPages.Clear();

            foreach (string sorterName in sortersName)
            {
                TabPage page = new TabPage(sorterName);
                arraysShowTabControl.TabPages.Add(page);

                DataGridView newDataGridView = new DataGridView();
                newDataGridView.Dock = DockStyle.Fill;
                page.Controls.Add(newDataGridView);
                newDataGridView.ReadOnly = true;
                newDataGridView.RowHeadersVisible = false;
                newDataGridView.ColumnHeadersVisible = false;
                newDataGridView.RowCount = twoDimensionalArray.GetLength(0);
                newDataGridView.ColumnCount = twoDimensionalArray.GetLength(1);

                for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
                {
                    for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                    {
                        newDataGridView.Rows[i].Cells[j].Value = twoDimensionalArray[i, j];
                    }
                }
            }
        }

        private void sortingArraysSpeedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //foreach (var item in checkedSorters)
            //{
            //    item.speedChanger = sortingArraysSpeedTrackBar.Value;
            //}
        }

        private void startSortingButton_Click(object sender, EventArgs e)
        {
            presenter.StartSortingArray();
        }

        public void UpdateCurrentArray(int[,] array, int firstSwapElementIndex, int secondSwapElementIndex)
        {
            DataGridView selectedDataGridView = (DataGridView)arraysShowTabControl.SelectedTab.GetNextControl(ActiveControl, true);
            
            int index = arraysShowTabControl.SelectedIndex;

            MessageBox.Show(firstSwapElementIndex.ToString() + " " + secondSwapElementIndex.ToString());

            int a = 0;
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    //selectedDataGridView.Rows[row].Cells[column].Value = array[row * array.GetLength(1) + column];
                    //selectedDataGridView.Rows[row].Cells[column].Style.BackColor = Color.Blue;
                    //selectedDataGridView.Refresh();

                    a++;
                }
            }

            //selectedDataGridView.Rows[firstSwapElementIndex].Cells[secondSwapElementIndex].Style.BackColor = Color.Red;
            //Thread thread = new Thread(() =>
            //{
            //    lock (threadLock)
            //    {

            //        for (int i = 0; i < rows; i++)
            //        {
            //            for (int j = 0; j < columns; j++)
            //            {
            //                selectedDataGridView.Rows[i].Cells[j].Value = sortedArray[i * columns + j];
            //                selectedDataGridView.Rows[i].Cells[j].Style.BackColor = Color.Blue;
            //                //selectedDataGridView.Refresh();
            //            }
            //        }
            //        MessageBox.Show(checkedSorters[index].methodTime.ToString() + " sec.");
            //    }
            //});
            //thread.Start();
        }
    }
}
