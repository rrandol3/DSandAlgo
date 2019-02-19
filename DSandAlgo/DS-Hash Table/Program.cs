using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Dictionary:");
            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1, "John");
            //dict.Add(2, "Jane");
            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Hashtable:");
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "John");
            //hashtable.Add(2, "Jane");
            //Console.WriteLine(hashtable[1]);
            //Console.WriteLine(hashtable[2]);

            //Console.WriteLine("Hashset:");
            //HashSet<int> hs = new HashSet<int>();
            //hs.Add(1);
            //hs.Add(1);
            //foreach (var item in hs)
            //{
            //    Console.WriteLine(item);
            //}

            //MyHashTable myHashTable = new MyHashTable(50);
            //myHashTable.Add("1602", "grapes");
            //myHashTable.Add("37", "apples");
            //myHashTable.Add("92", "peach");
            //myHashTable.Add("101", "orange");
            ////myHashTable.Remove("37");
            //Console.WriteLine("Display items in the Hash Table");
            //myHashTable.Display();

            int[] arr = { 2, 5, 1, 2, 3, 5, 1, 2, 4 };
            Console.WriteLine(FirstOccuringChar(arr));
        }

        //Given array get the first recurring character
        //eg {2,5,1,2,3,5,1,2,4}, should return 2
        //Time = O(n) Space = O(n)
        public static int FirstOccuringChar(int[] arr)
        {
            HashSet<int> hashset = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashset.Contains(arr[i]))
                {
                    return arr[i];
                }
                else
                {
                    hashset.Add(arr[i]);
                }
            }
            return -1;
        }

        //Given array get the first recurring character
        //eg {2,5,1,2,3,5,1,2,4}, should return 2
        //Time = O(n^2) Space = O(1)
        public static int FirstOccuringCharBF(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return arr[i];
                    }
                }
            }
            return -1;
        }

        //using generic Dictionary 
        public static int FirstOccuringCharUsingDictionary(int[] arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dictionary.ContainsKey(arr[i]))
                {
                    return arr[i];
                }
                else
                {
                    dictionary.Add(arr[i], arr[i]);
                }
            }
            return -1;
        }

        //using Hashtable
        public static int FirstOccuringCharUsingHashTable(int[] arr)
        {
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashtable.ContainsKey(arr[i]))
                {
                    return arr[i];
                }
                else
                {
                    hashtable.Add(arr[i], arr[i]);
                }
            }
            return -1;
        }
    }
}
