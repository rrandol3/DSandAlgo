﻿using System;
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
            int[] arr1 = { 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 6, 6, 6, 6, 6, 6 };
            int key = 2;
            foreach (var item in FindLowHighIndex(arr1, key))
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            Console.WriteLine(FindLowIndex(arr1, key));
            Console.WriteLine(FindHighIndex(arr1, key));
            Console.WriteLine();
;        }

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
            ReverseArray(arr, 0, n-1);
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
        public static void MoveZeroesToLeft(int[] arr)
        {

        }
    }
}
