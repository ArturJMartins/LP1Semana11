using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEnumerable
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T _item1;
        private T _item2;
        private T _item3;
        public Guarda3()
        {
            _item1 = default;
            _item2 = default;
            _item3 = default;
        }

        public T GetItem(int i)
        {
            return i switch
            {
                0 => _item1,
                1 => _item2,
                2 => _item3,
                _ => throw new IndexOutOfRangeException("Index must be 0,1,or 2")
            };
        }

        public void SetItem(int i, T item)
        {
            switch(i)
            {
                case 0:
                    _item1 = item;
                    break;
                case 1:
                    _item2 = item;
                    break;
                case 2:
                    _item3 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException("Index must be 0,1,or 2");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return _item1;
            yield return _item2;
            yield return _item3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}