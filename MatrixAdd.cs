using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace datastructure
{
    class MatrixAdd
    {

        /*
        * Complete the 'diagonalDifference' function below.
        *
        * The function is expected to return an INTEGER.
        * The function accepts 2D_INTEGER_ARRAY arr as parameter.
        */

        public static int diagonalDifference(List<List<int>> arr)
        {

            for (int i = 0; i < arr.Count; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
            return arr.Count;
        }

        public void load()
        {
           /* TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);*/

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = MatrixAdd.diagonalDifference(arr);

           /* textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();*/
        }

    }

}