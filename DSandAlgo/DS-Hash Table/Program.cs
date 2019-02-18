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
            Console.WriteLine("Dictionary:");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "John");
            dict.Add(2, "Jane");
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hashtable:");
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "John");
            hashtable.Add(2, "Jane");
            Console.WriteLine(hashtable[1]);
            Console.WriteLine(hashtable[2]);

            Console.WriteLine("Hashset:");
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(1);
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
