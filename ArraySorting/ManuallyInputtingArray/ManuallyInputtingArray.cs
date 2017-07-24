using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuallyInputtingArrayCreator
{
    public class ManuallyInputtingArray
    {
        public int[,] ManuallyInputting(int rows, int columns, string stringArray)
        {
            int[,] twoDimensionalArray = new int[rows, columns];

                    string[] stringArrayWithoutSpaces = stringArray.Split(' ');

                    if (stringArrayWithoutSpaces.Length != rows * columns)
                    {
                        MessageBox.Show("Wrong size of array");
                    }
                    else
                    {

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                int numericValue;
                                if (int.TryParse(stringArrayWithoutSpaces[i * columns + j], out numericValue))
                                {
                                    twoDimensionalArray[i, j] = numericValue;
                                }
                            }
                        }
                    }

            return twoDimensionalArray;
        }
    }
}
