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
            Node node = new Node(1);
            node.Next = new Node(2);
            node.Next.Next = new Node(3);
            node.Next.Next.Next = new Node(3);
            node.Next.Next.Next.Next = new Node(5);
            var test = RemoveDuplicates(node);
            while (test != null)
            {
                Console.Write(" " + test.Value);
                test = test.Next;
            }
        }

        //Given a sorted array of integers, return the index of the given key. Return -1 if not found.
        //Time O(log n), Space = O(1)
        public static int BinarySearch(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key > arr[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

        //Recurive Binary Search
        //Time = O(log n), Space = O(log n)
        public static int BinarySearchRecursive(int[] arr, int low, int high, int key)
        {
            if (low > high)
            {
                return -1;
            }
            int mid = low + (high - low) / 2;
            if (key == arr[mid])
            {
                return mid;
            }
            else if (key > arr[mid])
            {
                return BinarySearchRecursive(arr, mid + 1, high, key);
            }
            else
            {
                return BinarySearchRecursive(arr, low, mid - 1, key);
            }
        }

        //*****
        //Given a large array of integers and a window of size w, find the current maximum
        //value in the window as the window slides through the entire array.
        //Time = O(nw) where w is the window size, Space = O(w)
        //**Faster way using Java Deque class, Time = O(n), Space = O(w)**
        public static List<int> FindMaxInSlidingWindow(int[] arr, int w)
        {
            //{ -4, 2, -5, 3, 6 }
            List<int> results = new List<int>();//holds the results
            int max;//max
            for (int i = 0; i <= arr.Length - w; i++)//get subarrays
            {
                max = arr[i];//set max
                for (int j = 1; j < w; j++)//used to get max of current sub array
                {
                    if (arr[i + j] > max)//check to to see if array[i + j] > max
                    {
                        max = arr[i + j];//yes, make array[i + j] the new max
                    }
                }
                results.Add(max);//add max of current subarray to results
            }

            return results;
        }

        //*****
        //Search for a given number in a sorted array that has been rotated 
        //by some arbitrary number. Return -1 if the number does not exist.
        //Time = O(log n), Space = O(1)
        public static int SearchRotatedArray(int[] arr, int key)
        {
            //{ 4, 5, 6, 1, 2, 3 };
            int low = 0;
            int high = arr.Length - 1;
            if (low > high)
            {
                return -1;
            }
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key >= arr[mid] && key <= arr[high] && arr[mid] <= arr[high])//establish that key is in upper array
                {
                    low = mid + 1;
                }
                else if (key <= arr[mid] && key >= arr[low] && arr[low] <= arr[mid])//establish that key is in lower array
                {
                    high = mid - 1;
                }
                else if (arr[low] >= arr[mid])//shows where the rotations are, search lower array
                {
                    high = mid - 1;
                }
                else if (arr[high] <= arr[mid])//shows where the rotations are, search higher array
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        //*****
        //Given three integer arrays sorted in ascending order, 
        //find the smallest number that is common in all three arrays.
        //Time = O(n), Space = O(1)
        public static int FindSmallestCommonNumber(int[] arr1, int[] arr2, int[] arr3)
        {
            int i = 0;//iterator for arr1
            int j = 0;//iterator for arr2
            int k = 0;//iterator for arr3

            while (i < arr1.Length && j < arr2.Length && k < arr3.Length)//to stay inside the bounds of the arrays
            {
                if (arr1[i] == arr2[j] && arr2[j] == arr3[k])//if all are equal return number
                {
                    return arr1[i];
                }
                else if (arr1[i] <= arr2[j] && arr1[i] <= arr3[k])//if arr1[i] less than other array current items, move to next index in arr1
                {
                    i++;
                }
                else if (arr2[j] <= arr1[i] && arr2[j] <= arr3[k])//if arr2[j] less than other array current items, move to next index in arr2
                {
                    j++;
                }
                else if (arr3[k] <= arr1[i] && arr3[k] <= arr2[j])//if arr3[k] less than other array current items, move to next index in arr3
                {
                    k++;
                }
            }

            return -1;
        }

        //Given three integer arrays sorted in ascending order, 
        //find the smallest number that is common in all three arrays.
        //Time = O(n), Space = O(1)
        public static int FindSmallestCommonNumberUsingBinarySearch(int[] arr1, int[] arr2, int[] arr3)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                var arr2esults = BinarySearch(arr2, arr1[i]);
                var arr3esults = BinarySearch(arr3, arr1[i]);
                if (arr2esults != -1 && arr3esults != -1)
                {
                    return arr1[i];
                }
            }
            return -1;
        }

        //*****
        //Given an array of integers, rotate the array by N elements where N is an integer.
        //Time O(n), Space = O(1)
        public static void RotateArray(int[] arr, int n)
        {
            //{ 1, 6, 10, 14, 50 };
            int length = arr.Length;
            n = n % length;
            if (n < 0)
            {
                n = n + length;
            }
            ReverseArray(arr, 0, length - 1);
            ReverseArray(arr, 0, n - 1);
            ReverseArray(arr, n, length - 1);

        }
        //Reverse Array
        //Time O(n), Space = O(1)
        public static void ReverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                ++start;
                --end;
            }
        }

        //Given a sorted array of integers, return the low and high index of the given key. 
        //Return -1 if not found. The array length can be in the millions with many duplicates.
        //My version, Time = O(n), Space = O(n)
        //More efficient version using Binary Search Time = O(log n), Space = O(1)
        public static List<int> FindLowHighIndex(int[] arr, int key)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (key == arr[i])
                {
                    list.Add(i);
                    while (key == arr[i])
                    {
                        i++;
                    }
                    list.Add(i - 1);
                }
            }
            if (list.Count == 0)
            {
                list.Add(-1);
            }
            return list;
        }

        //*****
        //Given a sorted array of integers, return the low and high index of the given key. 
        //Return -1 if not found. The array length can be in the millions with many duplicates.
        //More efficient version using Binary Search Time = O(log n), Space = O(1)
        public static int FindLowIndex(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = low + (high - low) / 2;

            while (low <= high)
            {

                int mid_elem = arr[mid];

                if (mid_elem < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

                mid = low + (high - low) / 2;
            }

            if (low < arr.Length && arr[low] == key)
            {
                return low;
            }

            return -1;
        }

        public static int FindHighIndex(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = high / 2;

            while (low <= high)
            {

                int mid_elem = arr[mid];

                if (mid_elem <= key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

                mid = low + (high - low) / 2;
            }

            if (high == -1)
            {
                return high;
            }

            if (high < arr.Length && arr[high] == key)
            {
                return high;
            }

            return -1;
        }

        //Given an integer array, move all elements that are equal to 0 to the left while 
        //maintaining the order of other elements in the array.
        //My Approach, Time = O(n), Space = O(n)
        public static void MoveZeroesToLeft(int[] arr)
        {
            int zeros = 0;
            Queue<int> list = new Queue<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zeros++;
                }
                else
                {
                    list.Enqueue(arr[i]);
                }
            }
            for (int i = 0; i < zeros; i++)
            {
                arr[i] = 0;
            }
            for (int i = zeros; i < arr.Length; i++)
            {
                arr[i] = list.Dequeue();
            }
        }

        //*****
        //Given an integer array, move all elements that are equal to 0 to the left while 
        //maintaining the order of other elements in the array.
        //Better Approach, Time = O(n), Space = O(1)
        public static void MoveZeroesToLeft2(int[] arr)
        {
            if (arr == null)
            {
                return;
            }

            int write_index = arr.Length - 1;
            int read_index = arr.Length - 1;
            while (read_index >= 0)
            {
                if (arr[read_index] != 0)
                {
                    arr[write_index] = arr[read_index];
                    write_index--;
                }
                read_index--;
            }
            while (write_index >= 0)
            {
                arr[write_index] = 0;
                write_index--;
            }
        }

        //*****
        //Given a list of stock prices for n days, find the maximum profit with a single buy/sell activity.
        //Time = O(n), Space = O(1)
        public static List<int> MaxProfit(int[] arr)
        {
            //{ 8, 5, 12, 9, 19, 1 };
            List<int> results = new List<int>();
            int currentProfit = 0;
            int buy = arr[0];
            int sell = arr[1];
            int globalProfit = sell - buy;
            for (int i = 1; i < arr.Length; i++)
            {
                currentProfit = arr[i] - buy;
                if (currentProfit > globalProfit)
                {
                    globalProfit = currentProfit;
                    sell = arr[i];
                }
                if (buy > arr[i])
                {
                    buy = arr[i];
                }
            }
            results.Add(sell - globalProfit);
            results.Add(sell);
            return results;
        }

        //*****
        //Given an integer array, sort it in ascending order using quicksort.
        //Time = O(n log n), Space = O(1)
        public static void QuickSort(int[] arr)
        {
            QuickSortRecursion(arr, 0, arr.Length - 1);
        }
        public static void QuickSortRecursion(int[] arr, int low, int high)
        {
            if (high > low)
            {
                int pivot_index = Partition(arr, low, high);

                QuickSortRecursion(arr, low, pivot_index - 1);
                QuickSortRecursion(arr, pivot_index + 1, high);
            }
        }
        public static int Partition(int[] arr, int low, int high)
        {
            int pivot_value = arr[low];
            int i = low;
            int j = high;

            while (i < j)
            {
                while (i <= high && arr[i] <= pivot_value) i++;
                while (arr[j] > pivot_value) j--;

                if (i < j)
                {
                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            arr[low] = arr[j];
            arr[j] = pivot_value;

            // return the pivot index
            return j;
        }

        //*****
        //You are given an array (list) of interval pairs as input where each interval has a 
        //start and end timestamp. The input array is sorted by starting timestamps. You are 
        //required to merge overlapping intervals and return output array (list).
        //Consider the input array below.Intervals(1, 5), (3, 7), (4, 6), (6, 8) are overlapping 
        //so they should be merged to one big interval(1, 8). Similarly, intervals(10, 12) 
        //and(12, 15) are also overlapping and should be merged to(10, 15).
        //Time = O(n), Space = O(n)
        public static List<Tuple<int, int>> MergeOverlappingIntervals(List<Tuple<int, int>> pairs)
        {
            //Intervals(1, 5), (3, 7), (4, 6), (6, 8)

            return new List<Tuple<int, int>>();
        }

        //Given an array of integers and a value, determine if there are any two integers 
        //in the array whose sum is equal to the given value.
        //Time = O(n), Space = O(1)
        public static bool SumOfTwoValues(int[] arr, int val)
        {
            //{ 5, 7, 1, 2, 8, 4, 3 }
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i] - val;
                if (hs.Contains(temp))
                {
                    return true;
                }
                else
                {
                    hs.Add(arr[i]);
                }
            }
            return false;
        }

        //*****
        //Given the pointer/reference to the head of a singly linked list, reverse it and 
        //return the pointer/reference to the head of reversed linked list.
        //Time = O(n), Space = O(1)
        public static Node ReverseSinglyLinkedList(Node head)
        {
            //{ 5, 7, 1, 2, 8, 4, 3 }
            //5 -> 7 -> 1 -> 2 -> 8 -> 4 -> 3
            Node current = head;
            // no need to reverse if head is null 
            // or there is only 1 node.
            if (head == null ||
                head.Next == null)
            {
                return head;
            }

            Node list_to_do = head.Next;
            Node reversed_list = head;

            reversed_list.Next = null;

            while (list_to_do != null)
            {
                Node temp = list_to_do;
                list_to_do = list_to_do.Next;

                temp.Next = reversed_list;
                reversed_list = temp;
            }

            return reversed_list;
        }

        //*****
        //Remove duplicate nodes from a linked list of integers while keeping 
        //only the first occurrence of duplicates.
        //Time = O(n), Space = O(1)
        public static Node RemoveDuplicates(Node head)
        {
            HashSet<int> hs = new HashSet<int>();
            Node current = head;
            hs.Add(current.Value);
            while (current.Next != null)
            {
                if (!hs.Contains(current.Next.Value))
                {
                    hs.Add(current.Next.Value);
                    current = current.Next;
                }
                else
                {
                    current.Next = current.Next.Next;
                }
            }
            return head;
        }

        //Given the head of a linked list and a key, delete the node with this given key from the linked list.
    }
}

