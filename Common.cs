using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure
{
    public class Common
    {



        public void swap()
        {
            int a = 8;int b = -9;
            a = a + b;
            b= a-b;
            a = a-b ;
            Console.WriteLine("a{0},b{1}", a, b);
        }
    }
}
