using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.StringOperation
{
    internal class CountWordInSentence
    {
        public void countWordInSentence()
        {
            string input = "I am a good girl I am a good girl I am a good girl";
            int n = input.Trim().Split().Length;
            string[] arr = new string[n];
            arr = input.Split();
            Console.WriteLine($"no of words in sentence : " + arr.Length);
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
            Console.WriteLine($"no of repeated  words in sentence {count}");
        }
        static void Main(string[] args)
        {
            CountWordInSentence countWordInSentence = new CountWordInSentence();
            countWordInSentence.countWordInSentence();
        }
    }
}
