using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Hash_Table
{
    public class MyHashTable
    {
        string[] data;
        int size;
        public MyHashTable(int capacity)
        {
            size = capacity;
            data = new string[capacity];
        }

        public string Get(int key)
        {
            return string.Empty;
        }
        public void Add(string item)
        {
            int index = Hash(size++);
            data[index] = item;
        }
        public void Remove(string item)
        {

        }

        int Hash(int key)
        {
            int hash = 0;

            return hash;
        }
    }
}
