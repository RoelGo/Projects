using System;
using System.Collections.Generic;

namespace Lab9
{
    internal class PairFinder
    {
        public static List<Tuple<int, int>> FindPairs(int[] input, int sum)
        {
//            int[,] output = new int[input.GetLength(0),2];
            List<Tuple<int,int>> output = new List<Tuple<int, int>>();
            for (int index = 0; index < input.GetLength(0); index++)
            {
                for (int nextIndex = index; nextIndex < input.GetLength(0); nextIndex++)
                {
                    if (input[index] + input[nextIndex] == sum)
                    {
                        output.Add(new Tuple<int, int>(input[index], input[nextIndex]));
//                        output[index, 0] = input[index];
//                        output[index, 1] = input[nextIndex];
                    }
                }
            }
            return output;
        }
    }
}