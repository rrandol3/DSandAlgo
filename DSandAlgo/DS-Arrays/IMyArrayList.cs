using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Arrays
{
    public interface IMyArrayList<T>
    {
        T Get(int index);
        void Insert(T item);
        void Delete(T item);
        bool IsPresent(T item);
        void Display();
    }
}
