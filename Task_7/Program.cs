namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringValue = MyClass.FactoryMethod<string>();
            Console.WriteLine($"stringValue: {stringValue}");

            bool boolValue = MyClass.FactoryMethod<bool>();
            Console.WriteLine($"boolValue: {boolValue}");

            int intValue = MyClass.FactoryMethod<int>();
            Console.WriteLine($"int: {intValue}");


            Console.ReadKey();
        }
    }
}