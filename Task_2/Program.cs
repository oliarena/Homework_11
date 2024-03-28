namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int requiredCarNo = 3;
            
            CarCollection<string> cars = new CarCollection<string>();
            cars.Add("Toyota", new DateTime(2020, 1, 1));
            cars.Add("Mazda", new DateTime(2015, 1, 1));
            cars.Add("Suzuki", new DateTime(2019, 1, 1));
            cars.Add("Nissan", new DateTime(2017, 1, 1));
            cars.Add("Ford", new DateTime(2017, 1, 1));

            Console.WriteLine("Cars count: " + cars.Length);
            Console.WriteLine("Cars: \n" + cars.ToString());
            Console.WriteLine($"Car #{requiredCarNo}: {cars[requiredCarNo - 1]}");

            Console.ReadKey();
        }
    }
}