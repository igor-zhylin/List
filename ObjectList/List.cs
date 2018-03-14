using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectList
{
    public class List
    {
        private object[] _array;
        private const int DefaultArraySize = 4;
        public int Length { get { return Length; } }

        public List()
        {
            _array = new object[DefaultArraySize];
        }

        public object this[int index]
        {
            get { return _array[index]; }
        }

        public void Add(object objectToAdd)
        {
            if (objectToAdd == null)
            {
                throw new ArgumentNullException("Object cannot be NULL!");
            }
            
        }

        private void ResizeErray()
        {
        }
    }
}
