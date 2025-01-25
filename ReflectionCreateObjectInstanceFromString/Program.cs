namespace ReflectionCreateObjectInstanceFromString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fully qualified name of the class including the namespace
            string className = "ReflectionCreateObjectInstanceFromString.Cat";

            // Get the type of the class
            Type type = Type.GetType(className);
            if (type == null)
            {
                Console.WriteLine($"Class '{className}' not found.");
                return;
            }

            // Create an instance of the class
            object instance = Activator.CreateInstance(type);
            if (instance is Cat myClassInstance)
            {
                // Call a method on the created instance (optional)
                myClassInstance.Sound();
            }
        }
    }
}
