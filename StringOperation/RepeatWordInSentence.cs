using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.StringOperation
{
    internal class RepeatWordInSentence
    {
        public void repeatWordInSentence(string sentence)
        {
            string[] word = sentence.Split(' ');
            int i, j, count = 1;
            List<string> words = new List<string>();


            for (i = 0; i < word.Length - 1; i++)
            {
                for (j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j] && word[i] !=null && word[j]!=null)
                    {
                        word[j] = null;
                        count++; 
                    } 
                }

                if (count > 1)
                    words.Add(word[i] + ":" + count);
                count = 1;
            }

            for (int k = 0; k < words.Count; k++)
            {
                Console.WriteLine("{0}", words[k]);
            }


        }
        static void Main(string[] args)
        {
            RepeatWordInSentence repeatWordInSentence = new RepeatWordInSentence();
            repeatWordInSentence.repeatWordInSentence("I am not gonna live forever, but I wanna live while I am alive");
        }
    }
}
