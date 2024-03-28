using System.Collections;
using System.Collections.Generic;

namespace Task_6
{
    internal class Program
    {
        struct MyStruct
        {
            public int value;
        }

        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(new MyStruct { value = 1 });
            arrayList.Add("abc");
            arrayList.Add(new List<string>());

            for (int i = 0; i < arrayList.Count; i++)
            {
                // arrayList[i].value  :(

                if (arrayList[i] == null)
                {
                    continue;
                }

                Console.WriteLine(arrayList[i].GetType());
               
                if (arrayList[i].GetType() == typeof(MyStruct))
                {
                    MyStruct item = (MyStruct) arrayList[i];
                    Console.WriteLine("list length: " + item.value);
                } 
                else if ( arrayList[i].GetType() == typeof(List<string>))
                {
                    List<string> list = (List<string>)arrayList[i];
                    Console.WriteLine("list length: " + list.Count);
                }
                else 
                {
                    Console.WriteLine(arrayList[i]);
                }

                Console.WriteLine(new string('-', 25));
            }


            Console.ReadKey();
        }
    }
}