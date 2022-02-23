using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class MiList<T> : IEnumerable<T>
    {
        private int _index = 1;
        private T[] _array;
        public MiList(T value)
        {
            _array = new T[_index];
            _array[0] = value;
        }

        public MiList()
        {
            _array = new T[_index];
        }

        public void Add(T x)
        {
            if (_array.Length == _index)
            {
                System.Array.Resize(ref _array, _index * 2);
            }

            _array[_index++] = x;
        }

        public void AddRange(IEnumerable<T> range)
        {
            foreach (var item in range)
            {
                Add(item);
            }
        }

        public void RemoveAt(int x)
        {
            _array[x] = default;
        }

        public bool Remove(T item)
        {
            for (var i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }

            return false;
        }

        public void Sort()
        {
            Array.Sort(_array);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)_array).GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }
    }
}
