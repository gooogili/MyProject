using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingArrayFromDataBase
{
    public class LoadingFromDataBase
    {
        public int rows;
        public int columns;
        string array;
        public int[,] DBReader()
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
                Console.WriteLine(se.Message);
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
            connection.Open();

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
            
            return twoDimensionalArray;
        }
    }
}
