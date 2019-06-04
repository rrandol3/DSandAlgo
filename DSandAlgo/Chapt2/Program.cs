using System;

namespace Chapt2
{
    class Program
    {
        static void Main(string[] args)
        {
            TowerOfHanoi(3, 'A', 'B', 'C');
        }

        public static int Factorial(int n)
        {
            Console.WriteLine("Call Stack: " + n);
            if (n == 0)//base case
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        public static int LoopingDown(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            Console.WriteLine(n);
            return LoopingDown(n - 1);
        }

        public static int LoopingUp(int n)
        {
            if (n == 10)
            {
                Console.WriteLine(n);
                return 10;
            }
            Console.WriteLine(n);
            return LoopingUp(n + 1);
        }

        public static void TowerOfHanoi(int n, char frompeg, char topeg, char auxpeg)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disk 1 from peg " + frompeg + " to peg " + topeg);
                return;
            }
            TowerOfHanoi(n - 1, frompeg, auxpeg, topeg);
            Console.WriteLine("Move disk " + n + " from peg " + frompeg + " to peg " + topeg);
            TowerOfHanoi(n - 1, auxpeg, topeg, frompeg);
        }
    

        //Recursion Examples
        //-Fibonaci Series
        //Factorial Finding
        //Binary Search
        //Tree Traversals
        //Graph Traversals
        //Dynamic Programming examples
        //Divide and Conquer Algorithms
        //Tower of Hanoi
        //Backtracking Algorithms


    }
}
