namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("two");
            arrayList.Add("three");
            arrayList.Add(4);
            arrayList.Add(5);

            Console.WriteLine(arrayList.ToString());
            Console.WriteLine(new string('-', 25));

            int number = 4;
            Console.WriteLine(arrayList.Contains(number) ? $"Number {number} found" : $"Number {number} not found");

            Console.WriteLine("Remove number " + number);
            arrayList.Remove(number);
            Console.WriteLine(arrayList.ToString());
            Console.WriteLine(new string('-', 25));

            int index = 3;
            Console.WriteLine("Remove index " + index);
            arrayList.RemoveAt(index);
            Console.WriteLine(arrayList.ToString());
            Console.WriteLine(new string('-', 25));


            Console.WriteLine("Clear ");
            arrayList.Clear();
            Console.WriteLine(arrayList.ToString());
            Console.WriteLine(new string('-', 25));

            Console.ReadKey();
        }
    }
}