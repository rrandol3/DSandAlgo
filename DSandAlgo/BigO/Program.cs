using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    class Program
    {
        static void Main(string[] args)
        {
            LogAllPairs(new int[] { 1, 2, 3, 4, 5 });
        }

        #region O(1) Constant Time
        //O(1)
        public static void ConstantTime()
        {
            int a = 1;//O(1)
            int b = 2;//O(1)
            Console.WriteLine(a + b);//O(1)
        }
        #endregion

        #region O(n) Linear Time
        //O(n) - directly proportional to input
        public static void LinearTimear(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)//O(n)
            {
                Console.WriteLine(arr[i]);
            }
        }
        #endregion

        #region O(a + b)
        //O(a + b)
        public static void TwoInputsNotNested(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)//O(n)
            {
                Console.WriteLine(arr1[i]);
            }
            for (int j = 0; j < arr2.Length; j++)//O(n)
            {
                Console.WriteLine(arr2[j]);
            }
        }
        #endregion

        #region O(a * b)
        //O(a * b)
        public static void TwoInputsNested(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)//O(n)
            {
                for (int j = 0; j < arr2.Length; j++)//O(n)
                {
                    Console.WriteLine(arr1[i] + " " + arr2[j]);
                }
            }
        }
        #endregion

        #region O(n^2) Quadratic Time
        //O(n^2)
        //O(n * n) = O(n^2)
        //Log all pairs
        public static void LogAllPairs(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)//O(n)
            {
                for (int j = 0; j < arr.Length; j++)//O(n)
                {
                    Console.WriteLine(arr[i] + " " + arr[j]);
                }
            }
        }
        #endregion

        #region Space Complexity

        //Space Complexity O(1)
        public static void booo(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        //Space Complexity of O(n)
        public static string[] OofNExample(int n)
        {
            string[] hiArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                hiArray[i] = "hi";
            }
            return hiArray;
        }

        #endregion

    }
}
