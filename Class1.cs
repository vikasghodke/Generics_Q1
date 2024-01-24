using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Method_2
{
    internal class Class1
    {
        public void GeneRicDelete<T>(T[] Array, T element)
        {
            List<T> list = new List<T>();

            list = Array.ToList();


            foreach (T t in list)
            {
                Console.Write(t+" ");
            }
            Console.WriteLine("");

            list.Remove(element);

            foreach (T t in list)
            {
                Console.Write(t+" ");
            }
        }
    }
}
