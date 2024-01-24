using System;
using System.Globalization;

namespace Generic_Method_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubles = { 12.3, 34.5, 67.8, 90.9 };
            char[] chars = { 'a', 'b', 'c', 'd' };
            Class1 c1 = new Class1();

            c1.GeneRicDelete(numbers, 4);
            c1.GeneRicDelete(chars,'c');
            c1.GeneRicDelete(doubles, 34.5);
        }
    }
}
