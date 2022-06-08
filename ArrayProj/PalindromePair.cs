using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.ArrayProj
{
    internal class PalindromePair
    {
        /* Pick the pair which will give  the palindrome word  
         * after combinting the word
         *  eg. geekf+keeg = geekfkeeg  
         *  geekfkeeg is a palindrome word        
         */
        void palindromepair()
        {
            string[] arr = { "geekf", "geeks", "or", "ro","keeg", "abc", "bc" };
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
                        Console.WriteLine("The pair of words which will combined and form a Pallendrome word are: ({0}, {1})", arr[i], arr[j]);
                    }
                    reverse = null;
                }
            }
        }
        static void Main(string[] args)
        {
            PalindromePair palindromePair = new PalindromePair();
            palindromePair.palindromepair();
        }
    }
}
