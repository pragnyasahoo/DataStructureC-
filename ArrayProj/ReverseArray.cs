using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.ArrayProj
{
    internal class ReverseArray
    {
        public void reverseArray()
        {

            int[] arr = { 8, 7, 2, 5, 3, 1 };

            //int noOfReverse = 3;
            int arrLength = arr.Length;
            int temp = 0;
            for (int k = arrLength - 1; k >= 0; k--)
            {
                Console.WriteLine(arr[k]);
            }

            int i = 0;         //for pointing 1st element of the array
            int j = arr.Length - 1;  //for pointing last element of the array
            while (i < j)
            {
                //swap
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                //update i and j
                i++;
                j--;
            }
            foreach (var items in arr)
            {
                Console.WriteLine(items);
            }
        }
        static void Main(string[] args)
        {
            ReverseArray reverseArray = new ReverseArray();
            reverseArray.reverseArray();
        }
    }
}
