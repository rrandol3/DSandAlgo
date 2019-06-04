using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems___Coderust_Hacking_the_Coding_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 37;
            string binary = Convert.ToString(value, 2);
            foreach (var num in binary)
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
        }

        //Binary Search
        //Given a sorted array of integers, return the index of the given key.Return -1 if not found.
        //T = O(n), S = O(1)
        public static int BinarySearch(int[] nums, int key)
        {
            //nums = { 2, 4, 6, 8, 10, 12 }
            //key = 4
            int low = 0;//beginning of nums
            int high = nums.Length - 1;//end of nums
            int mid;//hold the mid point index
            while (low <= high)//stop iterating when low is the same or greater than high
            {
                mid = low + (high - low) / 2;//get mid index, to prevent overflow
                if (key == nums[mid])//check to see if key = mid
                {
                    return mid;//return mid
                }
                else if (key < nums[mid])//check to see if key less than the mid
                {
                    high = mid - 1;//since key is less, search lower half of the array
                }
                else
                {
                    low = mid + 1;//since key is greater, search the higher half of the array
                }
            }
            return -1;//return -1 if index of key is not found
        }

        ////Binary Search Recursive
        //T = O(n), S = O(log n)
        public static int BinarySeachRecursive(int[] nums, int key)
        {
            //nums = { 2, 4, 6, 8, 10, 12 }
            //key = 4
            int low = 0;
            int high = nums.Length - 1;
            return BinarySeachRecursiveHelper(nums, low, high, key);
        }
        public static int BinarySeachRecursiveHelper(int[] nums, int low, int high, int key)
        {
            if (low > high)//base case, index not found if low is greater than high
            {
                return -1;//return -1
            }
            int mid = low + (high - low) / 2;//get mid index, to prevent overflow
            if (key == nums[mid])//check to see if key = mid
            {
                return mid;//return mid
            }
            else if (key < nums[mid])//check to see if key less than the mid
            {
                high = mid - 1;//since key is less, search lower half of the array
                return BinarySeachRecursiveHelper(nums, low, high, key);//return with upated parameters
            }
            else
            {
                low = mid + 1;//since key is greater, search the higher half of the array
                return BinarySeachRecursiveHelper(nums, low, high, key);//return with upated parameters
            }
        }

        //Find Maximum in Sliding Window
        //Given a large array of integers and a window of size w, find the current maximum value 
        //in the window as the window slides through the entire array.
        public static List<int> FindMaxSlidingWindow(int[] nums, int w)
        {
            List<int> ans = new List<int>();
           
            return ans;
        }

        public static void ReverseWords(char[] sentence)
        {
            
        }

        public class Node
        {
            public int value;
            public Node prev;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }
    }
}

