using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms___Dynamic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 30;
            FibonacciRecursive(n);
            FibonacciRecursiveMemoize(n);
            Console.WriteLine("Regular Fib n = {0} took {1} calculations", n, calcualtions2);
            Console.WriteLine("Memoize Fib n = {0} took {1} calculations", n, calcualtions);
        }

        static Dictionary<int, int> cache = new Dictionary<int, int>();//For dynamic programming 
        //O(n)
        static int calcualtions = 0;
        public static int FibonacciRecursiveMemoize(int n)
        {
            calcualtions++;
            if (cache.ContainsKey(n))//check to see if n is in the cache
            {
                return cache[n];//return cache[n]
            }
            else
            {
                if (n < 2)//if n < 2
                {
                    return n;//yes, return n
                }
                else//assign cache[n] = fib number, since cache[n] is not in the cache already
                {
                    cache[n] = FibonacciRecursiveMemoize(n - 1) + FibonacciRecursiveMemoize(n - 2);
                    return cache[n];// return cache[n]
                }
            }
        }


        //For Reference only, already implemented it in the Recursion Project
        //O(2^n)
        static int calcualtions2 = 0;
        public static int FibonacciRecursive(int n)
        {
            calcualtions2++;
            if (n < 2)
            {
                return n;
            }
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
