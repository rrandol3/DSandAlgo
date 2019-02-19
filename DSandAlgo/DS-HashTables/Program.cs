using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            //strongly typed hash table 
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Reggie", "Husband");
            dict.Add("Krista", "Wife");
            Console.WriteLine("Dictionary contains the following values:");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("Reggie is a " + dict["Reggie"]);
            Console.WriteLine("Krista is a " + dict["Krista"]);
            Console.WriteLine("Contains Key Krista " + dict.ContainsKey("Krista"));
            Console.WriteLine("Contains Value Husband " + dict.ContainsValue("Husband"));
            dict.Remove("Reggie");
            Console.WriteLine("Dictionary contains the following values:");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Hashtable 
            //weakly typed hash table
            Hashtable ht = new Hashtable();
            ht.Add("Reggie", "Husband");
            ht.Add("Krista", "Wife");
            Console.WriteLine("Hashtable contains the following values:");
            Console.WriteLine("Krista" + " " + ht["Krista"]);
            Console.WriteLine("Reggie" + " " + ht["Reggie"]);
            ht.Remove("Reggie");
            Console.WriteLine("Hashtable contains the following values:");
            Console.WriteLine("Krista" + " " + ht["Krista"]);
            Console.WriteLine("Still contains Reggie " + ht.Contains("Reggie"));

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
