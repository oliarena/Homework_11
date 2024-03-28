namespace Task_7
{
    internal class MyClass
    {
        /*
         * JFI
         * 
         public static T FactoryMethod<T>() where T : new()
        {
            return new T();
        }
        */

        public static T FactoryMethod<T>() 
        {
            if (typeof(T) == typeof(string))
            {
                return (T)Activator.CreateInstance(typeof(string), new object?[] { "".ToCharArray() });
            }
            return Activator.CreateInstance<T>();
        }
    }
}
