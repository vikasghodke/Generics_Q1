using System;

namespace Generics_Method_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            double[] doubles = { 12.3, 345.5, 56.4, 89.9 };
            char[] chars = { 'a', 'b', 'c', 'd' };

            Class1 c1=new Class1();
            c1.DeleteMetod(numbers);
            c1.DeleteMethod1(doubles);
            c1.DeleteMethod2(chars);

        }
    }
}
