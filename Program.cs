﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace datastructure
{
    class Program
    {
          public static void Main(string[] args)
        { 

            Pallendron pallendron = new Pallendron();
            //pallendron.stringPallendrion();
            pallendron.countRepeatedNoInArray();
            //pallendron.countRepeatedStringInArray();
            // pallendron.countWordInSentence();
            //pallendron.combinationUtil();
            // pallendron.reverseArray(); 


            //Matrix ms = new   Matrix();
            //ms.matrixMultiplication();

            arraycode arraycode = new arraycode();
            //arraycode.firstRepeatedoccureanceIndex();
            // arraycode.MaximumProductSubarray(); 
            // arraycode.repeatWordInSentence("I am good I am good good");
            // arraycode.removeDuplicateintValue();
            // arraycode.removeDuplicateStringValue();

            //new
            //pallendron. palindromepair();
            //pallendron.reverseName("pragnya SAhoo");\

            int[] a = { -1, 0, 3, 5, 9, 12 };

            //int d = pallendron.Search(a,9);

            /* Common c = new Common();
             c.swap();*/
            MatrixAdd matrixadd = new MatrixAdd();

            matrixadd.load(); 

            }  
    }
}
