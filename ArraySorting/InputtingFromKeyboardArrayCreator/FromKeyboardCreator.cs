using System;

namespace InputtingFromKeyboardArrayCreator
{
    public class FromKeyboardCreator
    {
        public int[,] KeyboardReading(int rows, int columns)
        {
            int[,] twoDimensionalArray = new int[rows, columns];

            try
            {
                string stringArray = Console.ReadLine();

                if (stringArray != null)
                {
                    string[] stringArrayWithoutSpaces = stringArray.Split(' ');

                    if (stringArrayWithoutSpaces.Length != rows * columns)
                    {
                        Console.WriteLine("Wrong array size");
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
                                else
                                {
                                    Console.WriteLine("Parsing failed");
                                }
                            }
                        }
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Array is empty");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Something was wrong");
            }


            return twoDimensionalArray;
        }
    }
}
