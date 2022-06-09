using System;
using System.Collections.Generic;
using System.Linq;
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
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (i != j && array[i] == array[j])
                    {
                        count++;
                        Console.Write("first repeated Index {0} and value {1}", i, array[i]);
                        break;
                    }

                }
                if (count > 0)
                {
                    break;
                }

            }
            if (count == 0)
            {
                Console.Write("first repeated Index -1");
            }

        }

       
       

        public void removeDuplicateintValue()
        {
            HashSet<int> hashset = new HashSet<int>();

            //int[] arr = new int[5];
            int[] arr = { 10, 2, 3, 3, 2 };
            //step -1
            for (int i = 0; i < arr.Length; i++)
            {
                for (int K = 0; K < arr.Length; K++)
                {
                    if (arr[i] != arr[K])
                    {
                        hashset.Add(arr[i]);
                        break;
                    }
                }
            }
            foreach (var items in hashset)
            {
                Console.WriteLine(items);
            }



            //step 2
            int[] distinct = arr.Distinct().ToArray();
            foreach (var items in distinct)
            {
                Console.WriteLine(items);
            }

            //step 2
            int count = 0;
            int n = arr.Length;
            int[] arrtemp = new int[n];
            List<int> lst = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int j;
                for (j = 0; j < count; j++)
                {
                    if (arr[i] == arr[j])
                        break;
                }
                if (j == count)
                {
                    // temp[count] = arr[i];
                    lst.Add(arr[i]);
                    count++;
                }
            }

            Console.WriteLine("printing----");
            foreach (var items in lst)
            {
                Console.WriteLine(items);
            }
        }

        public void removeDuplicateStringValue()
        {
            //String
            HashSet<string> hashset1 = new HashSet<string>();
            string[] arr1 = { "qw", "qw", "pp", "qw", "pp", "ee" };
            //step -1
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int K = 0; K < arr1.Length; K++)
                {
                    if (arr1[i] != arr1[K])
                    {
                        hashset1.Add(arr1[i]);
                        break;
                    }
                }
            }
            Console.WriteLine("1. calculation----");
            foreach (var items in hashset1)
            {
                Console.WriteLine(items);
            }

            //step 2

            string[] distinct1 = arr1.Distinct().ToArray();
            Console.WriteLine("2. calculation----");
            foreach (var items in distinct1)
            {
                Console.WriteLine(items);
            }

            //step 3
            int count = 0;
            string[] arr = { "qw", "qw", "pp", "qw", "pp", "pp", "qw", "ee", "kk", "ee", "ee", "ee" };
            int n = arr.Length;
            string[] arrtemp = new string[n];
            List<string> lst = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                int j;
                for (j = 0; j < count; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (i > j)
                        {
                            count++;

                        }
                        break;
                    }
                }


                if (j == count)
                {
                    // temp[count] = arr[i];
                    lst.Add(arr[i]);
                    count++;
                }
            }

            Console.WriteLine("printing----");
            foreach (var items in lst)
            {
                Console.WriteLine(items);
            }
        }

    }
}
