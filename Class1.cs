using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Method_1
{
    public class Class1
    {
        public int[] DeleteMetod(int[] numbers)
        {
            Console.WriteLine("Enter a Element to delete");
            int value = Convert.ToInt32(Console.ReadLine());
            var newarr = Array.Empty<int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==value)
                {
                    continue;
                }
                else
                {
                    newarr = newarr.Append(numbers[i]).ToArray();
                    Console.WriteLine(numbers[i]);  
                }
            }
            return newarr;

        }

        public double[] DeleteMethod1(double[] doubles)
        {
            Console.WriteLine("Enter Elements to Delete");
            double value = Convert.ToDouble(Console.ReadLine());
            var newarr = Array.Empty<double>();
            for(int i=0;i<doubles.Length;i++)
            {
                if (doubles[i] == value)
                {
                    continue;
                }
                else
                {
                    newarr = newarr.Append(doubles[i]).ToArray();
                    Console.WriteLine(doubles[i]);
                }
            }
            return newarr;
        }
        public char[] DeleteMethod2(char[] chars) 
        {
            Console.WriteLine("Enter a Character to Delete");
            char value = Convert.ToChar(Console.ReadLine());
            var newarr = Array.Empty<char>();
            for(int i=0;i<chars.Length;i++)
            {
                if (chars[i] == value)
                {
                    continue;
                }
                else
                {
                    newarr = newarr.Append(chars[i]).ToArray();
                    Console.WriteLine(chars[i]);
                }
            }
            return newarr;
            
        }
    }
}
