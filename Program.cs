using System;
using System.Collections.Generic;

namespace Generic_Method_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubles = { 12.3, 34.5, 56.7, 32.4 };
            char[] chars = { 'a', 'b', 'c', 'd' };

            Class1<int> c1 = new Class1<int>();
            Class1<double> c2 = new Class1<double>();
            Class1<char> c3 = new Class1<char>();

            c1.Adelete(numbers, 3);
            c2.Adelete(doubles, 12.3);
            c3.Adelete(chars, 'b');

        }
    }
}
