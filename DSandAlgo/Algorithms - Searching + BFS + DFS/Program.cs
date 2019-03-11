using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms___Searching___BFS___DFS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 9, 5, 3, 6, 8, 2, 1 };
            int itemToFind = 19;
            Console.WriteLine("Is {0} present in the list: {1}", itemToFind, BinarySearch(numArray, itemToFind));
        }

        //O(n)
        public static bool LinearSearch(int[] numArray, int itemToFind)
        {
            //{ 9, 5, 3, 6, 8, 2, 1 };
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] == itemToFind)
                {
                    return true;
                }
            }
            return false;
        }

        //O(log n)
        public static bool BinarySearch(int[] numArray, int itemToFind)
        {
            int low = 0;
            int high = numArray.Length - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (itemToFind == numArray[mid])
                {
                    return true;
                }
                if (itemToFind > numArray[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return false;
        }
    }
}
