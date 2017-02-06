using System;

namespace MultiDimentionalComparison
{
    public class ArrayComparator
    {
        internal static string[,] Compare(int[,] array1, int[,] array2)
        {
            string[,] output =
                new string[Math.Min(array1.GetLength(0), array2.GetLength(0)),
                    Math.Min(array1.GetLength(1), array2.GetLength(1))];
            for (int row = 0; row < output.GetLength(0); row++)
            {
                for (int collumn = 0; collumn < output.GetLength(1); collumn++)
                {
                    if (array1[row, collumn] != array2[row, collumn])
                    {
                        output[row, collumn] = array1[row, collumn] + " -- " + array2[row, collumn];
                    }
                }
            }

            return output;
        }
    }
}