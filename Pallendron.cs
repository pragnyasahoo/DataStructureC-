using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure
{
    class Pallendron
    {

        public void stringPallendrion()
        {
            string input = "Madam";
            int n = input.Length;
            char[] inputValues = input.ToCharArray();
            StringBuilder reverseword = new StringBuilder();

            string[] arr = new string[n];
            for (int i = n - 1; i >= 0; i--)
            {
                reverseword.Append(inputValues[i]);
            }

            if (reverseword.ToString().ToLower().Equals(input.ToLower()))
                Console.WriteLine("pallendon");

        }
        public void countRepeatedNoInArray()
        {
            int[] arr = { 10, 2, 3, 3, 2 };
            Dictionary<int, int>   dic = new Dictionary<int,int>();
            int count = 0;
            //step
            for (int i = 0; i < arr.Length; i++)
            {
                for (int K = i + 1; K < arr.Length; K++)
                {
                    if (arr[i] == arr[K])
                    {
                        count++;
                        //break;
                    }

                }
                if(count>0  && !dic.ContainsKey(arr[i]))
                {
                    dic.Add(arr[i], count);
                }
            }
            foreach(var item in dic)
            {
                Console.WriteLine("Value {0} : Key {1}",item.Value, item.Key);
            }
            Console.WriteLine($"count{count} ", count);
        }
        public void countRepeatedStringInArray()
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
            Console.WriteLine($"count{count} ", count);
        }

        public void combinationUtil()
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
                        Console.Write($"pair found {arr[i]},{arr[j]}");
                    }
                }
            }
        }
        public void countWordInSentence()
        {
            string input = "I am a good girl I am a good girl I am a good girl";
            int n = input.Trim().Split().Length;
            string[] arr = new string[n];
            arr = input.Split();
            Console.WriteLine($"no of words " + arr.Length);
            int count = 0;

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
            Console.WriteLine($"no of repeated  words {count}");
        }
        /*
         * Input: arr[] = {1, 2, 3, 4, 5, 
                 6, 7, 8, 9, 10}
           k = 3
            Output: 8 9 10 1 2 3 4 5 6 7
         */
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

        //new
        public void palindromepair()
        {
            string[] arr = { "geekf", "geeks", "or", "keeg", "abc", "bc" };
            int N = 6;
            int i, j;
            string temp = null;
            // StringBuilder reverse = new StringBuilder();
            string reverse = null;
            for (i = 0; i < N - 1; i++)
            {
                for (j = i + 1; j < N - 1; j++)
                {
                    temp = arr[i] + arr[j];
                    for (int k = temp.Length - 1; k >= 0; k--)
                    {
                        reverse += temp[k];
                    }

                    if (temp == reverse.ToString())
                    {
                        Console.WriteLine("Pallendrome {0} {1}", arr[i], arr[j]);
                    }
                    reverse = null;
                }
            }
        }


        public void reverseName(string Name)
        {
            string[] arr = Name.Split();
            string reverse = null;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                char[] a = arr[i].ToCharArray();
                for (int k = a.Length - 1; k >= 0; k--)
                {
                    reverse += a[k].ToString();
                }
                reverse += " ";
            }
            Console.Write(reverse);

        }

        public int Search(int[] nums, int target)
        {
            int i, Output = 0;
            for (i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] == target)
                {
                    Output = i;
                    break;
                }
                else
                    Output = -1;
            }
            return Output;

        }

    }
}
