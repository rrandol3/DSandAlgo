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


    }
}
