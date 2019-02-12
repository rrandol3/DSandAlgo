using System;
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
            string[] strings = { "a", "b", "c", "d" };
            //4*4 = 16 bytes of storage

            List<string> list = new List<string> { "a", "b", "c", "d" };
            list.Insert(0, "e");
            Console.WriteLine(list[0]);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            
        }


    }
}
