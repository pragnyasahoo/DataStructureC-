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
        
        /*
         * Input: arr[] = {1, 2, 3, 4, 5, 
                 6, 7, 8, 9, 10}
           k = 3
            Output: 8 9 10 1 2 3 4 5 6 7
         */
         
    }
}
