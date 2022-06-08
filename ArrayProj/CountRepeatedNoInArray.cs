using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.ArrayProj
{
    internal class CountRepeatedNoInArray
    {
         void countRepeatedNoInArray()
        {
            int[] arr = { 10, 2, 3, 3, 2 };
            display(arr);
            Dictionary<int, int> dic = new Dictionary<int, int>();
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
                if (count > 0 && !dic.ContainsKey(arr[i]))
                {
                    dic.Add(arr[i], count);
                }
            } 
            foreach (var item in dic)
            {              
                Console.WriteLine($"The Item {item.Key} is reapeated {count} times in array"); 
            }
            
        }
        private void display(int[] array)
        {
            Console.Write("{");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                }
                else
                {

                    Console.Write(array[i] + ",");
                }
            }
            Console.Write("}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        { 
            CountRepeatedNoInArray countRepeatedWordInArray = new CountRepeatedNoInArray();
            countRepeatedWordInArray.countRepeatedNoInArray();  
        }
    }
}
