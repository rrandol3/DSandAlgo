using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Arrays
{
    public class MyArrayList<T> : IMyArrayList<T>
    {
        const int defaultCapacity = 2;
        int capacity = defaultCapacity;
        int count;
        T[] _items = new T[defaultCapacity];

        public int Count
        {
            get { return count; }
        }
        public T Get(int index)
        {
            if (index < 0 || index >= _items.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            return _items[index];
        }
        public void Insert(T item)
        {
            if (count >= capacity)
            {
                EnsureCapacity();
            }
            _items[count] = item;
            count++;
        }
        public void Delete(T item)
        {
            int indexToDelete = -1;
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    indexToDelete = i;
                }
            }
            if (indexToDelete < 0)
            {
                return;
            }
            else
            {
                T[] newArray = new T[_items.Length - 1];
                for (int i = indexToDelete; i < _items.Length - 1; i++)
                {
                    _items[i] = _items[i + 1];//shift items to the left
                }
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = _items[i];
                }
                _items = newArray;
                count--;
            }
        }
        //Find/Search //O(n) now could use Binary Search to make O(log n)
        public bool IsPresent(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public void Display()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                Console.Write(_items[i] + " ");
            }
            Console.WriteLine();
        }
        private void EnsureCapacity()
        {
            T[] newArray = new T[capacity * 2];
            for (int i = 0; i < _items.Length; i++)
            {
                newArray[i] = _items[i];
            }
            _items = newArray;
            capacity = capacity * 2;
        }
    }
}
