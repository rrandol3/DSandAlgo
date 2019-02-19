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

        public string Get(string key)
        {
            var address = Hash(key);
            if (address != 0)
            {
                if (String.IsNullOrWhiteSpace(data[address]))
                {
                    return "No value at that location!";
                }
                return data[address];
            }
            return "Could not find item with that key!";
        }
        public void Add(string key, string value)
        {
            var address = Hash(key);
            if (string.IsNullOrWhiteSpace(data[address]))
            {
                data[address] = value;
            }
            data[address] = value;
        }
        public void Remove(string key)
        {
            var address = Hash(key);
            data[address] = "";
        }

        public void Display()
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(data[i]))
                {
                    Console.WriteLine(data[i]);
                }
            }
        }

        private int Hash(string key)
        {
            int hash = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hash = (hash + Convert.ToUInt16(key) * i) % size;
            }
            return hash;
        }
    }
}
