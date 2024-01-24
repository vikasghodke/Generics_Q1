using System;
using System.Collections;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 54, 45, 67, 89, 65 };
            float[] floats = {3.4f, 45.6f, 67.43f, 90.4f};
            string[] strings = { "t", "g", "k", "m" };

            Class1<int> intmin = new Class1<int>();
            Class1<float> floatmin = new Class1<float>();
            Class1<string> stringmin = new Class1<string>();

            int minInt = intmin.FindMin(number);
            float minfloat = floatmin.FindMin(floats);
            string minstring = stringmin.FindMin(strings);

            Console.WriteLine("Minimum Integer" + minInt);
            Console.WriteLine("Minimum Float" + minfloat);
            Console.WriteLine("Minimum string" + minstring);

        }
    }
}
