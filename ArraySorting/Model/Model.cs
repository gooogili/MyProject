using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraySorting.Model.Interfaces;
using System.Data.SqlClient;
using System.Data;
using ISorterNamespace;

namespace ArraySorting.Model
{
    public class Model : IModel
    {
        public int[,] Array { get; set; }

        public List<ISorter> Sorters { get; set; }
        public List<string> namesOfSorters { get; set; }

        private static Model modelInstance;

        public static Model GetModelInstance()
        {
            if (modelInstance == null)
            {
                modelInstance = new Model();
            }
            return modelInstance;
        }

        public void SortersLoading()
        {
            Sorters = DllHunter.FindSorters();
        }

        public List<string> LoadNamesOfSorters(List<ISorter> sorters)
        {
            namesOfSorters = new List<string>();
            foreach (ISorter sorter in sorters)
            {
                namesOfSorters.Add(sorter.methodName);
            }
            return namesOfSorters; 
        }

        public void RandomArrayGenerate(int rows, int columns, int minArrayValue, int maxArrayValue)
        {
            int[,] twoDimensionalArray = new int[rows, columns];

            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    twoDimensionalArray[i, j] = random.Next(minArrayValue, maxArrayValue);
                }
            }
            Array = twoDimensionalArray;
        }

        public void ManuallyInputAray(int rows, int columns, string stringArray)
        {
            int[,] twoDimensionalArray = new int[rows, columns];

            string[] stringArrayWithoutSpaces = stringArray.Split(' ');

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
            Array = twoDimensionalArray;
        }


        public int rows;
        public int columns;
        string array;
        public void LoadArrayFromDB()
        {
            int[,] twoDimensionalArray = null;

            string connectionString = @"Data Source=DESKTOP-A10I9M0; Initial Catalog=ArrayDB; Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException se)
            {
                throw se;
            }

            SqlCommand getArraySizeCommand = new SqlCommand("Select * From InputArrays", connection);

            SqlDataReader arrayReader = getArraySizeCommand.ExecuteReader(CommandBehavior.CloseConnection);
            {
                while (arrayReader.Read())
                {
                    rows = (int)arrayReader.GetValue(1);
                    columns = (int)arrayReader.GetValue(2);
                    array = (string)arrayReader.GetValue(3);
                }
            }

            connection.Close();
            //connection.Open();

            string[] stringArrayWithoutSpaces = array.Split('\t');
            twoDimensionalArray = new int[rows, columns];
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
            Array = twoDimensionalArray;
        }

        public int[] Convert2DArrayTo1D(int[,] twoDimensionalArray)
        {
            int[] oneDimensionalArray = new int[twoDimensionalArray.Length];

            int arrayCounter = 0;
            int numberOfRows = twoDimensionalArray.GetLength(0);
            int numberOfColumns = twoDimensionalArray.GetLength(1);

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    oneDimensionalArray[arrayCounter++] = twoDimensionalArray[i, j];
                }
            }
            return oneDimensionalArray;
        }

        public int[,] Convert1DArrayTo2D(int[] oneDimensionalArray, int numberOfRows, int numberOfColumns)
        {
            int[,] twoDimensionalArray = new int[numberOfRows, numberOfColumns];

            int arrayCounter = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    twoDimensionalArray[i, j] = oneDimensionalArray[arrayCounter++];
                }
            }
            return twoDimensionalArray;
        }
    }
}
