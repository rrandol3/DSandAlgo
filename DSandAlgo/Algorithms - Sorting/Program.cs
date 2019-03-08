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
            //int[] intArray = { 8, 2, 4, 33, 11, 5, 6, 7 };
            //string[] strArray = { "a", "z", "d", "r", "c", "u" };

            //Console.WriteLine("Before intArray sort:");
            //foreach (var item in intArray)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();
            //Array.Sort(intArray);
            //Console.WriteLine("After intArray sort:");
            //foreach (var item in intArray)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Before strArray sort:");
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    Console.Write(" " + strArray[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Before strArray sort:");
            //Array.Sort(strArray);
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    Console.Write(" " + strArray[i]);
            //}
            //Console.WriteLine();
            int[] numArray = { 9, 5, 3, 6, 8, 2, 1 };
            Console.WriteLine("numArray before sort:");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(" " + numArray[i]);
            }
            Console.WriteLine();
            BubbleSortVisualizer(numArray);
            Console.WriteLine();
            Console.WriteLine("numArray after sort:");
            BubbleSort(numArray);
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(" " + numArray[i]);
            }

            Console.WriteLine();
        }

        //O(n^2)
        public static void BubbleSort(int[] intArray)
        {
            //{ 9, 5, 3, 6, 8, 2, 1 };
            int n = intArray.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
            }
        }
        public static void BubbleSortVisualizer(int[] intArray)
        {
            Console.WriteLine("assign n to " + intArray.Length);
            int n = intArray.Length;
            Console.WriteLine("Enter outer loop i");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter inner loop j");
                for (int j = 0; j < n - 1; j++)
                {
                    Console.WriteLine("Is intArray[{0}]({1}) greater than intArray[{2}]({3})?", j, intArray[j], j + 1, intArray[j + 1]);
                    if (intArray[j] > intArray[j + 1])
                    {
                        Console.WriteLine("Yes swap intArray[{0}]({1}) with intArray[{2}]({3})", j, intArray[j], j + 1, intArray[j + 1]);
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                    Console.WriteLine("Increment j = {0}", j + 1);
                }
                Console.WriteLine("Increment i = {0}", i + 1);
                Console.WriteLine("{0} pass thru:", i + 1);
                for (int k = 0; k < n; k++)
                {
                    Console.Write(" " + intArray[k]);
                }
                Console.WriteLine();
            }
        }
    }
}
