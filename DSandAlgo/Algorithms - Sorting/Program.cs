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
            int[] numArray = { 9, 5, 3, 6, 8, 2, 1 };
            QuickSort(numArray, 0, numArray.Length - 1);
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(" " + numArray[i]);
            }
            Console.WriteLine();
        }

        //O(n^2)
        public static void BubbleSort(int[] numArray)
        {
            //{ 9, 5, 3, 6, 8, 2, 1 };
            int n = numArray.Length;//number of items in array
            for (int i = 0; i < n; i++)//keeps track of the traversal count through the array
            {
                for (int j = 0; j < n - 1; j++)//used for comparision of items in the array
                {
                    if (numArray[j] > numArray[j + 1])//check to see if j > j + 1, if true, then swap
                    {
                        int temp = numArray[j];
                        numArray[j] = numArray[j + 1];
                        numArray[j + 1] = temp;
                    }
                }
            }
        }

        //O(n^2)
        public static void SelectionSort(int[] numArray)
        {
            //{ 9, 5, 3, 6, 8, 2, 1 };
            int n = numArray.Length;//number of items in array
            for (int i = 0; i < n; i++)//tracks the items already in their right position
            {
                int indexOfSmallest = i;//index of current smallest
                for (int j = i + 1; j < n; j++)//compares each item to find the smallest index, (j = i + 1 bc no need to check items that already in right position)
                {
                    if (numArray[indexOfSmallest] > numArray[j])//if new smallest is > than j 
                    {
                        indexOfSmallest = j;//new smallest = j
                    }
                }
                //swap new smallest(indexOfSmallest) with previous smallest(i)
                int temp = numArray[i];
                numArray[i] = numArray[indexOfSmallest];
                numArray[indexOfSmallest] = temp;
            }
        }

        //O(n^2)
        public static void InsertionSort(int[] numArray)
        {
            //{ 9, 5, 3, 6, 8, 2, 1 };
            int n = numArray.Length;//number of items in array
            int temp;
            int j;
            for (int i = 1; i < n; i++)//used to pick value we want to insert in sorted left array
            {
                temp = numArray[i];//the value we want to insert
                for (j = i; j > 0 && (numArray[j - 1] > temp); j--)//user for the comparision, values are shifted to the right until we find the appropriate position of the temp value
                {
                    numArray[j] = numArray[j - 1];
                }
                numArray[j] = temp;
            }
        }

        //O (n log n) TODO: need to do some more research and finish
        public static int[] MergeSort(int[] numArray)
        {
            //{ 9, 5, 3, 6, 8, 2, 1 };
            if (numArray.Length == 1)
            {
                return numArray;
            }

            int low = 0;
            int high = numArray.Length;
            int mid = low + (high - low) / 2;
            int[] left = new int[mid];
            int[] right = new int[numArray.Length - left.Length];
            for (int i = 0; i < mid; i++)
            {
                left[i] = numArray[i];
            }
            int k = mid;
            for (int j = 0; k < high; j++, k++)
            {
                right[j] = numArray[k];
            }

            return Merge(MergeSort(left),MergeSort(right));
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int[] newArray = new int[left.Length + right.Length];
            int i = 0;
            int leftIndex = 0;
            int rightIndex = 0;
            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    newArray[i] = left[leftIndex];
                    leftIndex++;
                    i++;
                }
                else
                {
                    newArray[i] = right[rightIndex];
                    rightIndex++;
                    i++;
                }
            }
            return newArray;
        }

        //O(n^2)
        public static void QuickSort(int[] nums, int low, int high)
        {
            int pivot;
            if (high > low)
            {
                pivot = Partition(nums, low, high);
                QuickSort(nums, low, pivot - 1);
                QuickSort(nums, pivot + 1, high);
            }
        }

        public static int Partition(int[] nums, int low, int high)
        {
            int pivotItem = nums[low];
            int left = low;
            int right = high;
            while (left < right)
            {
                while (nums[left] <= pivotItem && left < right)
                {
                    left++;
                }
                while (nums[right] > pivotItem)
                {
                    right--;
                }
                if (left < right)
                {
                    Swap(nums, left, right);
                }
            }
            nums[low] = nums[right];
            nums[right] = pivotItem;
            return right;
        }

        public static void Swap(int[] nums, int left, int right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }
        
    }
}
