using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.ArrayProj
{
    internal class MaxProductInArray
    {
        public void MaximumProductSubarray()
        {
            /*
             * Input:
                N = 5
                Arr[] = {6, -3, -10, 0, 2}
                Output: 180
                Explanation: Subarray with maximum product
                is 6, -3, -10 which gives product as 180.

                Input:sum
                N = 6
                Arr[] = {2, 3, 4, 5, -1, 0}
                Output: 120
                Explanation: Subarray with maximum product
                is 2, 3, 4, 5 which gives product as 120.
             */

            int[] arr = { 2, 3, 4, 5, -1, 0 };
            int arrSize = arr.Length;
            int result = 0;
            for (int i = 0; i < arrSize; i++)
            {
                int mul = arr[i];
                // Traversing in current subarray
                for (int j = i + 1; j < arrSize; j++)
                {

                    // Updating result every time
                    // to keep an eye over the
                    // maximum product
                    result = Math.Max(result, mul);
                    mul *= arr[j];
                }
            }
            Console.WriteLine($"Maximum Product Subarray {result}");

        }

        static void Main(string[] args)
        {
            MaxProductInArray maxProductInArray = new MaxProductInArray();
            maxProductInArray.MaximumProductSubarray();
        }
    }
}
