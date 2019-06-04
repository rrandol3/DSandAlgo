using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 5, 7, 11, 11, 11, 13 };
            var ans = AllPrimes(18);
            foreach (var item in ans)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        /*
        5.3 Reverse Bits        Write a program that takes a 64-bit word and returns the 64-bit word consisting of
        the bits of the input word in reverse order.For example, if the input is alternating 1s
        and 0s, i.e., (1010...10), the output should be alternating 0s and 1s, i.e., (0101...01).        */

        public static int ReverseBits(long n)
        {
            int rev = 0;
            while (n > 0)
            {
                rev <<= 1;
                if ((long)(n & 1) == 1)
                {
                    rev ^= 1;
                }
                n >>= 1;
            }
            return rev;
        }

        /* 
        5.11 Recantgle Intersection
        Write a program which tests if two rectangles have a nonempty intersection. If the
        intersection is nonempty, return the rectangle formed by their intersection.
        */
        public static Rectangle IntersectRectangle(Rectangle r1, Rectangle r2)
        {
            if (!IsIntersect(r1, r2))
            {
                return new Rectangle(0, 0, -1, -1);
            }
            return new Rectangle
                (
                    Math.Min(r1.x, r2.x), Math.Max(r1.y, r2.y),
                    Math.Min(r1.x + r2.width, r2.x + r2.width) - Math.Max(r1.x, r2.x),
                    Math.Min(r1.y + r2.height, r2.y + r2.height) - Math.Max(r1.y, r2.y)
                );
        }

        public static bool IsIntersect(Rectangle r1, Rectangle r2)
        {
            return r1.x < r2.x + r2.width && r1.x + r2.width >= r2.x
                && r1.y < r2.y + r2.height && r1.y + r2.height >= r2.y;
        }

        /*
        6.5 Delete Duplicates from a sorted Array
        Write a program which takes asinput a sorted array and updatesitso that all dupli¬
        cates have been removed and the remaining elements have been shifted left to fill the
        emptied indices. Return the number of valid elements. Many languages have library
        functionsfor performing this operation—you cannot use these functions.
        */

        //O(n) time and space approach
        public static int RemoveDuplicatesFromArray(int[] arr)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                hs.Add(arr[i]);
            }

            return hs.Count;
        }

        //O(n) time and O(1) space approach
        public static int RemoveDuplicatesFromArrayOptimal(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new Exception("The array is empty");
            }

            int writeIndex = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[writeIndex - 1] != arr[i])//check to see if arr items are equal
                {
                    arr[writeIndex] = arr[i];
                    writeIndex++;
                }
            }

            return writeIndex;
        }

        /*
        6.8 Enumerate All Primes to N
        Write a program that takes an integer argument and returns all the primes between1
        and that integer. For example, if the inputis18, you should return (2,3,5,7,11,13,17).
        */

        public static List<int> AllPrimes(int n)
        {
            List<int> listOfPrimes = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    listOfPrimes.Add(i);
                }
            }
            return listOfPrimes;
        }

        public static bool IsPrime(int n)
        {
            return false;
        }
    }


    //class for problem 5.11
    public class Rectangle
    {
        public int x, y, width, height;
        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = width;
        }
    }
}
