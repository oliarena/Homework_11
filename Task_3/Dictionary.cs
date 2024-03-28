using System.Xml.Linq;

namespace Task_3
{
    internal class Dictionary<TKey, TValue>
    {
        private readonly List<TKey> _key;
        private readonly List<TValue> _value;
        private int _count;

        public string this[int index]
        {
            get
            {
                if (index >= _key.Count)
                {
                    return "Index is out of the range.";
                }
                return _key[index] + " - " + _value[index];
            }
        }

        public TValue? this[TKey index]
        {
            get
            {
                for (int i = 0; i < _key.Count; i++)
                {
                    if ((string)(object)_key[i] == (string)(object)index)
                    {
                        return _value[i];
                    }
                }
                return default;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public Dictionary()
        {
            _count = 0;
            _key = new List<TKey>();
            _value = new List<TValue>();
        }

        public void Add(TKey key, TValue value) 
        { 
            _key.Add(key);
            _value.Add(value);
            _count++;
        }

        public override string ToString()
        {
            string result = String.Empty;
            for (int i = 0; i < _key.Count; i++)
            {
                result += String.Format($"#{i + 1}. {_key[i]}: {_value[i]} \n");
            }

            return result;
        }

    }
}
