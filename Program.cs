using System;
using System.Collections.Generic;
using System.Linq;

namespace datastructure
{
    class Program
    {
          public static void Main(string[] args)
        {
             
            test test1 = new test();
            // test1.removeDuplicateintValue();
            // test1.removeDuplicateStringValue();

            Pallendron pallendron = new Pallendron();
            //pallendron.stringPallendrion();
            pallendron.countRepeatedNoInArray();
            //pallendron.countRepeatedStringInArray();
            // pallendron.countWordInSentence();
            //pallendron.combinationUtil();
            // pallendron.reverseArray(); 


            //Matrix ms = new   Matrix();
            //ms.matrixMultiplication();

            arraycode arraycode = new arraycode();
            //arraycode.firstRepeatedoccureanceIndex();
            // arraycode.MaximumProductSubarray();
            //new
            //pallendron. palindromepair();
            //pallendron.reverseName("pragnya SAhoo");
            int[] a = { -1, 0, 3, 5, 9, 12 };

            //int d = pallendron.Search(a,9);

           /* Common c = new Common();
            c.swap();*/

            }
        class test
        {
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
                string[] arr = { "qw", "qw", "pp", "qw", "pp", "pp","qw","ee","kk","ee","ee","ee" };
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
}
