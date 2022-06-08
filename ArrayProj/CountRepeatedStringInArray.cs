using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.ArrayProj
{
    internal class CountRepeatedStringInArray
    {
        static void Main(string[] args)
        {

            string[] arr = { "qw", "qw", "pp", "qw", "pp", "ee" };
            int count = 0;
            //step -1
            for (int i = 0; i < arr.Length; i++)
            {
                for (int K = i + 1; K < arr.Length; K++)
                {
                    if (arr[i] == arr[K])
                    {
                        count++;
                        break;
                    }

                }
            }
            Console.WriteLine($"Repeated Item in the array is : {count} ", count);
        }
    }
}
 
