namespace Task_4
{
    internal class ArrayList
    {
        private object[] _items;

        public object this[int index] => _items[index];
        public int Length => _items.Length;

        public ArrayList() 
        {
            _items = Array.Empty<object>();
        }

        public void Add(object value)
        {
            object[] array = new object[_items.Length + 1];
            Array.Copy(_items, array, _items.Length);
            array[array.Length - 1] = value;
            _items = array;
        }

        public void Clear()
        {
            _items = Array.Empty<object>();
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] is object o && o.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(object value)
        {
            return Array.IndexOf((Array)_items, value, 0, _items.Length);
        }

        public void Remove(object obj)
        {
            int index = IndexOf(obj);
            if (index >= 0)
            {
                RemoveAt(index);
            }      
        }

        public void RemoveAt(int index)
        {
            if (index >= _items.Length)
            {
                Console.WriteLine("Index is out of the range");
                return;
            }
            
            object[] array = new object[_items.Length - 1];
            int j = 0;
            for (int i = 0; i < _items.Length; i++)
            {
                if (i != index)
                {
                    array[j] = _items[i];
                    j++;
                }
            }

            _items = array;
        }

        public override string ToString()
        {
            return "Array: " + String.Join(';', _items);
        }
    }
}
