using System;

namespace RandomArrayCreator
{
    public class RandomCreator
    {
        public int[,] RandomGeneration(int rows, int columns, int minArrayValue, int maxArrayValue)
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
            return twoDimensionalArray;
        }
    }
}
