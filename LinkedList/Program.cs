using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine(list.ToString()); 

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            list.AppendHead(15);

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            list.InsertAfter(4, 10);

            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
