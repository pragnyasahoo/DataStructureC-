using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.ArrayProj
{
    internal class SumPairCombination
    {
        /* Find the comibantion which item are provide the sum as 10 as
         * e.g. 8+2=10 and 7+3=10
         * so combinations are (8,2) and (7,3)*/

        void combinationUtil()
        {
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int sum = 10;
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength; i++)
            {
                for (int j = i + 1; j < arrLength; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine($"Addition Pair found which is present is array {arr[i]},{arr[j]}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            SumPairCombination sumPairCombination = new SumPairCombination();
            sumPairCombination.combinationUtil();
        }
    }

}
