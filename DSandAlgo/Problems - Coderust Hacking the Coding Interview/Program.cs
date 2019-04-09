using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS_Linked_Lists;

namespace Problems___Coderust_Hacking_the_Coding_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[0];
            int windowSize = 0;
            var ans = FindMaxSlidingWindow2(nums, windowSize);
            foreach (var num in ans)
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
        public static int[] FindMaxSlidingWindow(int[] nums, int windowSize)
        {
            //nums = { -4, 2, -5, 3, 6 }
            //windowSize = 3
            int[] ans = new int[nums.Length - windowSize + 1];//creates a array to hold the ans
            for (int i = 0; i <= nums.Length - windowSize; i++)//incrementer for the set of numbers
            {
                int max = nums[i];//set max to i index
                for (int j = 1; j < windowSize; j++)//incrementer for each num in sub array
                {
                    if (nums[i + j] > max)//check if nums[i + j] in sub array is greater than max
                    {
                        max = nums[i + j];//assign nums[i + j] to max
                    }
                    ans[i] = max;//assign max to ans
                }
            }
            return ans;//return ans
        }

        public static int[] FindMaxSlidingWindow2(int[] nums, int windowSize)
        {
            //nums = { -4, 2, -5, 3, 6 }
            //windowSize = 3
            int[] ans = new int[nums.Length - windowSize + 1];
            if (nums.Length == 0)
            {
                return nums;
            }
            Stack<int> maxes = new Stack<int>();
            int currMax = nums[0];
            for (int i = 0; i < windowSize - 1; i++)
            {
                if (nums[i] > currMax)
                {
                    currMax = nums[i];
                }
            }
            maxes.Push(currMax);
            for (int i = windowSize; i < nums.Length; i++)
            {
                if (nums[i] > maxes.Peek())
                {
                    maxes.Push(nums[i]);
                }
                else
                {
                    int max = maxes.Peek();
                    maxes.Push(max);
                }
            }
            for (int i = ans.Length - 1; i >= 0; i--)
            {
                ans[i] = maxes.Pop();
            }
            return ans;//return ans
        }
    }
}

