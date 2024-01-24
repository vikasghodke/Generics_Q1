using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Method_3
{
    public class Class1<T>
    {
        public void Adelete(T[] Array,T element)
        {
            List<T> list = new List<T>();
            list=Array.ToList();

            foreach(T t in list)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine(" ");

            list.Remove(element); 

            foreach(T t in list)
            {
                Console.WriteLine(t+" ");
            }

        }
        
    }
}
