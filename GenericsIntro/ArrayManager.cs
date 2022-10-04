using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class ArrayManager<T>
    {
        private T[] _typeArray;

        public ArrayManager()
        {
            _typeArray = new T[0];
        }

        public int Count { get { return _typeArray.Length; } }

        public T[] Add(T value)
        {
            var tempArray = _typeArray;

            _typeArray = new T[_typeArray.Length + 1];

            for (int i = 0, x = tempArray.Length; i < x; i++)
            {
                _typeArray[i] = tempArray[i];
            }

            _typeArray[_typeArray.Length - 1] = value;

            return _typeArray;
        }
    }
}
