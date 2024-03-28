using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class CarCollection<T>: List<T>
    {
        private readonly  List<string> _names;
        private readonly List<DateTime> _years;

        public new string this[int index]
        {
            get
            {
                if (index < _names.Count)
                {
                    return _names[index] + ' ' + _years[index].Year;
                }
                else 
                { 
                    return "Not found"; 
                } 
            }
        }

        public int Length
        {
            get 
            { 
                return _names.Count; 
            }
        }

        public CarCollection()
        {
            _names = new List<string>();
            _years = new List<DateTime>();
        }

        public void Add(string name, DateTime year) 
        { 
            _names.Add(name);
            _years.Add(year);
        }

        public void ClearAll()
        {
            _names.Clear();
            _years.Clear();
        }

        public override string ToString() 
        { 
            string result = String.Empty;
            for(int i = 0; i < _names.Count; i++) 
            { 
                result += String.Format($"#{i + 1}: {_names[i]}. Year {_years[i].Year} \n");
            }

            return result;
        }
    }
}

