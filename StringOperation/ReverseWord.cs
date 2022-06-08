using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.StringOperation
{
    internal class ReverseWord
    {
        public string reverseWord(string Name)
        {
            char[] arr = Name.ToCharArray();
            string reverseWholeAsOneWord = null;

            for (int k = arr.Length - 1; k >= 0; k--)
            {
                reverseWholeAsOneWord += arr[k].ToString();
            }
            reverseWholeAsOneWord += " ";
            return reverseWholeAsOneWord;

        }


        static void Main(string[] args)
        {
            ReverseWord reverseWord = new ReverseWord();
            string reversTheWord = reverseWord.reverseWord("Pragnya Sahoo");
            Console.WriteLine($"After reverse the word with space {reversTheWord}");
        }
    }
}
