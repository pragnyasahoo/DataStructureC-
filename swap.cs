using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure
{
    internal class swap
    {
        public void SwapToNo()
        {
            int a = 8;int b = -9;
            a = a + b;
            b= a-b;
            a = a-b ;
            Console.WriteLine("After swap a = {0},b = {1}", a, b);
        }
        static void Main(string[] args)
        {
            swap swap = new swap();
            swap.SwapToNo();
        }
    }
}
