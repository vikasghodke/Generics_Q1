using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Class1<T> where T: IComparable<T>
    {
        public T FindMin(T[] Array)
        {
           if(Array.Length==0)
            {
                Console.WriteLine("Out of bound");
            }
            T min = Array[0];

            for(int i = 1; i < Array.Length; i++)
            {
                if (Array[i].CompareTo(min) < 0)
                {
                    min= Array[i];
                }
            }
            return min;
        }
    }
}
