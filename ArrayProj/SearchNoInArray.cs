using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure.ArrayProj
{

    //Find the location of the search item
    internal class SearchNoInArray
    {
        public int searchNoInArray(int[] array, int targetItem)
        {
            int i, Location = 0;
            for (i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] == targetItem)
                {
                    Location = i;
                    break;
                }
                else
                    Location = -1;
            }
            return Location;

        }
        private void display(int[] array)
        {
            Console.Write("{");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i == array.Length-1)
                {
                    Console.Write(array[i]);
                }
                else
                {

                    Console.Write(array[i] + ",");
                }
            }
            Console.Write("}");
        }
        


        static void Main(string[] args)
        {
            int[] a = { -1, 0, 3, 5, 9, 12 };
            SearchNoInArray searchNoInArray = new SearchNoInArray();
            searchNoInArray.display(a);
            int Location = searchNoInArray.searchNoInArray(a, 9);
            Console.WriteLine($" The Item in at location {Location}");
        }
    }
}
