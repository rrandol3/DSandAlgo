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
            int[] numArray = { 1, 2, 3, 5, 6, 8, 9 };
            int itemToFind = 0;
            Console.WriteLine("Is {0} present in the list: {1}", itemToFind, BinarySearcRecursive(numArray, itemToFind));
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
            //{ 1, 2, 3, 5, 6, 8, 9 };
            int low = 0;
            int high = numArray.Length - 1;
            while (low <= high)
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

        //O(log n), Space = O(n)
        public static bool BinarySearcRecursive(int[] numArray, int itemToFind)
        {
            //{ 1, 2, 3, 5, 6, 8, 9 };
            int low = 0;
            int high = numArray.Length - 1;
            return BinarySearchRecursiveHelper(numArray, low, high, itemToFind);
        }
        public static bool BinarySearchRecursiveHelper(int[] numArray, int low, int high, int itemToFind)
        {
            int mid = low + (high - low) / 2;
            if (numArray[mid] == itemToFind)
            {
                return true;
            }
            if (low >= high)
            {
                return false;
            }
            if (itemToFind > numArray[mid])
            {
                low = mid + 1;
                return BinarySearchRecursiveHelper(numArray, low, high, itemToFind);
            }
            else
            {
                high = mid - 1;
                return BinarySearchRecursiveHelper(numArray, low, high, itemToFind);
            }
        }
    }
}
