using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToSolveCodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1,2,4,7};
            Console.WriteLine(HasPairWithSum(arr1, 8));
        }

        //Give 2 arrays, create a function that lets a user know (true/false) where these 2 arrays contains any common items
        //Brute Force: O(a * b) nested for loops with 2 inputs, Space Complexity = O(1)
        public static bool TwoArrayContainsCommonBF(string[] arr1, string[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)//O(b)
                {
                    if (arr1[i] == arr2[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //Time Complexity = O(a + b) Space Complexity = O(n)
        //Create HashSet to hold values of arr1, loop through arr1 and add arr1 values to Hashet
        //then loop through arr2 and check to see if HashSet contains any items of arr2, if yes return else return false
        public static bool TwoArrayContainsCommon(string[] arr1, string[] arr2)
        {
            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < arr1.Length; i++)//O(a)
            {
                if (!hs.Contains(arr1[i]))
                {
                    hs.Add(arr1[i]);
                }
            }
            for (int j = 0; j < arr2.Length; j++)//O(b)
            {
                if (hs.Contains(arr2[j]))
                {
                    return true;
                }
            }
            return false;
        }

        //Google Youtube Interview Question
        //Given a array find out if the there is a combination of 2 values that equal a particular sum
        //Eg. [1, 2, 4, 4] and sum = 8, 4 + 4 = 8, so return true otherwise return false
        //Brute Force O(n^2)
        public static bool HasPairWithSumBF(int[] arr, int sum)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Better Approach O(n)
        public static bool HasPairWithSum(int[] arr, int sum)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hs.Contains(arr[i]))
                {
                    return true;
                }
                hs.Add(sum - arr[i]);
            }
            return false;
        }
    }
}
