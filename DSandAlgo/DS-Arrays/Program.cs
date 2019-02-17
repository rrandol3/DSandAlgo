using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyArrayList<int> arr = new MyArrayList<int>();
            //arr.Insert(1);
            //arr.Insert(2);
            //arr.Insert(3);
            //arr.Insert(4);
            //Console.WriteLine("After Inserts:");
            //arr.Display();
            //arr.Delete(2);
            //Console.WriteLine("After Delete:");
            //arr.Display();
            //Console.WriteLine("Is 4 present:");
            //Console.WriteLine(arr.IsPresent(5));
            //Console.WriteLine("Is item at index 5:");
            //try
            //{
            //    Console.WriteLine(arr.Get(5));
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //string str = "Reggie";
            //Console.WriteLine("String Before:");
            //Console.WriteLine(str);
            //Console.WriteLine("String After:");
            //Console.WriteLine(ReverseString(str));
            //PrintReverse(str);
            int[] arr1 = { 0, 3, 4, 31 };
            int[] arr2 = { 4, 6, 30 };
            int[] ansArray = MergeSortedArrays(arr1, arr2);
            for (int i = 0; i < ansArray.Length; i++)
            {
                Console.Write(ansArray[i] + " ");
            }
        }

        //Value Type Example
        public static void ValueTypeExample()
        {
            Console.WriteLine("Value Type Example:");
            int a = 2;
            Console.WriteLine("a = " + a);
            Console.WriteLine("int b = a");
            int b = a;
            Console.WriteLine("b = " + b);
            Console.WriteLine("add 2 to b");
            b = b + 2;
            Console.WriteLine("b = " + b);
            Console.WriteLine("a is unchanged, a = " + a);
        }
        //Reference Type Example
        public static void ReferenceTypeExample()
        {
            Console.WriteLine("Reference Type Example:");
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(2);
            Console.WriteLine("arrayList1 = " + arrayList1[0]);
            Console.WriteLine("arrayList2 = arrayList1");
            ArrayList arrayList2 = arrayList1;
            Console.WriteLine("arrayList2 = " + arrayList2[0]);
            Console.WriteLine("arrayList2 remove 2 and add 3");
            arrayList2.Remove(2);
            arrayList2.Add(3);
            Console.WriteLine("arrayList2 = " + arrayList2[0]);
            Console.WriteLine("arrayList1 = " + arrayList1[0]);
        }

        //Reverse string
        //Time O(n) Space O(n)
        public static string ReverseString(string str)
        {
            //[r e g g i e]
            //[e i g g e r]
            if (String.IsNullOrEmpty(str))
            {
                return "Invalid input";
            }
            char[] strArr = str.ToCharArray();//convert string into char[]
            int first = 0;
            int last = strArr.Length - 1;
            for (; first < last; first++, last--)//O(n)
            {
                char temp = strArr[first];//swap
                strArr[first] = strArr[last];
                strArr[last] = temp;
            }
            str = new string(strArr);
            return str;
        }

        //Going through an array backwards
        //Time O(n)
        public static void PrintReverse(string strArray)
        {
            int lastIndex = strArray.Length - 1;//gets last index
            for (int i = lastIndex; i >= 0; i--)//decrements starting from last index
            {
                Console.WriteLine(strArray[i]);
            }
        }

        //Merge two sorted arrays
        //Time O(a + b) Space O(a + b) 
        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            //eg. [0, 3, 4, 31] [4, 6, 30]
            //    [0, 3, 4, 4, 6, 30 , 31]
            int[] ansArray = new int[(arr1.Length) + (arr2.Length)];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < arr1.Length && j < arr2.Length)//traverse both arrays at same time
            {
                if (arr1[i] < arr2[j])
                {
                    ansArray[k] = arr1[i];
                    k++;
                    i++;
                }
                else
                {
                    ansArray[k] = arr2[j];
                    k++;
                    j++;
                }
            }
            //store remaining elements of arr1
            while (i < arr1.Length)
            {
                ansArray[k] = arr1[i];
                k++;
                i++;
            }
            //store remaining elements of arr2
            while (j < arr2.Length)
            {
                ansArray[k] = arr1[j];
                k++;
                j++;
            }
            return ansArray;
        }

    }
}
