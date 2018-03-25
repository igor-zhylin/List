/// <summary>
/// Created By Zhylin
/// </summary>
namespace ObjectList
{
    using System;
    using System.Data;

    public class List
    {
        private object[] _array;
        private const int DefaultArrayListSize = 4;
        private const int ArrayLengthMultiplier = 2;
        public int Length { get; private set; }


        public List()
        {
            _array = new object[DefaultArrayListSize];
        }

        public object this[int index]
        {
            get { return _array[CheckIndex(index)]; }
        }

        private int CheckIndex(int index)
        {
            return index <= Length ? index : throw new IndexOutOfRangeException();
        }

        public void Add(object objectToAdd)
        {
            CheckObjectZeroValues(objectToAdd);
            if (Length < _array.Length)
            {
                AddElement(objectToAdd);
            }
            else
            {
                ResizeArray();
                AddElement(objectToAdd);
            }
        }

        private void CheckObjectZeroValues(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Object cannot be NULL!");
            }
        }

        private void AddElement(object obj)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == null)
                {
                    _array[i] = obj;
                    Length++;
                    return;
                }
            }
        }

        private void ResizeArray()
        {
            var resizedArray = new object[Length * ArrayLengthMultiplier];
            for (int i = 0; i < _array.Length; i++)
            {
                resizedArray[i] = _array[i];
            }
            _array = resizedArray;
        }

        public void InsertAt(int index, object objectToInsert)
        {
            CheckObjectZeroValues(objectToInsert);
            if (Length == _array.Length)
            {
                ResizeArray();
            }
            InsertElement(index, objectToInsert);
        }

        private void InsertElement(int index, object element)
        {
            for (int i = Length; i >= index; --i)
            {
                _array[i + 1] = _array[i];
            }
            _array[index] = element;
            Length++;
        }

        public void RemoveAt(int index)
        {
            if (index > Length)
            {
                throw new IndexOutOfRangeException("Element does not exist!");
            }
            RemoveElement(index);
        }

        private void RemoveElement(int index)
        {
            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
        }

        public int IndexOf(object item)
        {
            int index = SearchIndex(item);
            return index == -1 ? throw new ArgumentNullException("Item Not Found") : index;
        }

        private int SearchIndex(object item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Reverse()
        {
            for (int i = 0; i < Length / 2; i++)
            {
                object tmp = _array[i];

                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmp;
            }
        }

        public void Clear()
        {
            _array = null;
            Length = 0;
        }
    }
}