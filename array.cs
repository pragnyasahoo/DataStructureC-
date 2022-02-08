using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure
{
   public class arraycode
    {
        /*
         * Input:
        n = 7
        arr[] = {1, 5, 3, 4, 3, 5, 6}
        Output: 2
        Explanation: 
        5 is appearing twice and its first appearence is at index 2 which is less than 3 whose first occuring index is 3.
         */
        public void firstRepeatedoccureanceIndex()
        {
            //int[] array = new int[5];
            int[] array = { 10, 2, 4, 5, 0, 2, 3 };
            int arraySize = array.Length;
            int count = 0;
            for (int i=0;i< arraySize; i++)
            {
                for (int j=i+1;j<arraySize;j++)
                {
                    if (i != j && array[i]== array[j] )
                    {
                        count++;
                        Console.Write("first repeated Index {0} and value {1}",  i, array[i]);
                        break;
                    }                   
                   
                }
                if(count>0)
                {
                    break;
                }
                
            }
            if(count==0)
            {
                Console.Write("first repeated Index -1");
            }

        }

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
            for(int i=0;i< arrSize; i++)
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
    }
}
