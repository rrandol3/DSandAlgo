using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms___Recursion
{
    public class Program
    {
        int counter = 0;
        static void Main(string[] args)
        {
            //Program program = new Program();
            //var test = program.Inception();
            //Console.WriteLine(test);
            //Console.WriteLine(FactorialRecursive(5));
            //Console.WriteLine(FibonacciIterative(12));
            Console.WriteLine(ReverseStringRecursive("yoyo master"));
        }

        //O(n)
        public string Inception()
        {
            Console.WriteLine(counter);
            if (counter > 3)
            { 
                return "done!";
            }
            counter++;
            return Inception();
        }
        //O(n)
        public static int FactorialRecursive(int number)
        {
            if (number == 2)
            {
                return 2;
            }
            return number * FactorialRecursive(number - 1);
        }
        //O(n)
        public static int FactorialIterative(int number)
        {
            int answer = 1;
            for (int i = number; i > 0; i--)
            {
                answer = answer * i;
            }
            return answer;
        }
        //O(2^n)
        public static int FibonacciRecursive(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        //O(n)
        public static int FibonacciIterative(int n)
        {
            int ans = 0;
            int curr = 0;
            int next = 1;
            int i = 1;
            while (i < n)
            {
                ans = curr + next;
                curr = next;
                next = ans;
                i++;
            }
            return ans;
        }
        //O(2^n)
        public static string ReverseStringRecursive(string str)
        {
            if (str == "")
            {
                return "";
            }
            else
            {
                return str[str.Length - 1] + ReverseStringRecursive(str.Substring(0, str.Length - 1));
            }
        }
        
    }
}
