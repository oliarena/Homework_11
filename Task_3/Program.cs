namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("one", 1);
            dictionary.Add("two", 2);
            dictionary.Add("three", 3);
            dictionary.Add("four", 4);

            Console.WriteLine(dictionary.ToString());
            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Total count: " + dictionary.Count);

            int recordNumber = 5;
            Console.WriteLine($"Record #{recordNumber + 1}: " + dictionary[recordNumber]);
            recordNumber = 2;
            Console.WriteLine($"Record #{recordNumber + 1}: " + dictionary[recordNumber]);

            string key = "four";
            Console.WriteLine($"Record '{key}': " + dictionary[key]);

            Console.ReadKey();
        }
    }
}