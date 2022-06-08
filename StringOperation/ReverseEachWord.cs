using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.StringOperation
{
    internal class ReverseEachWord
    {

        /* Enter Pragnya Sahoo Get the Output as  ayngarP oohaS*/
        public void reverseEachWord(string Name)
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
            Console.WriteLine($"The word after Reverse is {reverse}");

        }
        
        static void Main(string[] args)
        {
            ReverseEachWord reverseEachWord = new ReverseEachWord(); 
            reverseEachWord.reverseEachWord("Pragnya Sahoo"); 
        }
    }
}
