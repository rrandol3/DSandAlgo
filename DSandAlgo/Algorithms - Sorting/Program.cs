using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms___Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 8, 2, 4, 33, 11, 5, 6, 7 };
            string[] strArray = { "a", "z", "d", "r", "c", "u" };

            Console.WriteLine("Before intArray sort:");
            foreach (var item in intArray)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Array.Sort(intArray);
            Console.WriteLine("After intArray sort:");
            foreach (var item in intArray)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.WriteLine("Before strArray sort:");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write(" " + strArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Before strArray sort:");
            Array.Sort(strArray);
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write(" " + strArray[i]);
            }
            Console.WriteLine();
        }
    }
}
