using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    public class SampleClass
    {
        public int PublicField;
        private string PrivateField;

        public SampleClass() { }

        public SampleClass(int value)
        {
            PublicField = value;
        }

        public void PublicMethod() { }

        private void PrivateMethod() { }

        public int PublicProperty { get; set; }

        private string PrivateProperty { get; set; }
    }

    class reflectionExample
    {
        public static void getInfo()
        {
            Type type = typeof(SampleClass);

            Console.WriteLine("Class: " + type.Name);

            Console.WriteLine();

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Number of Fields: " + fields.Length);
            foreach (var field in fields)
            {
                Console.WriteLine($"Field: {field.Name} = {field.FieldType.Name} ({field.Attributes})");
            }

            Console.WriteLine();

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Number of Properties: " + properties.Length);
            foreach (var property in properties)
            {
                Console.WriteLine($"Property: {property.Name} = {property.PropertyType.Name}({property.GetMethod?.Attributes ?? property.SetMethod?.Attributes})");
            }

            Console.WriteLine();

            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Number of Methods: " + methods.Length);
            foreach (var method in methods)
            {
                Console.WriteLine($"Method: {method.Name} Return Type: {method.ReturnType.Name} = ({method.Attributes}) ");
            }

            Console.WriteLine();

            ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Number of Constructors: " + constructors.Length);
            foreach (var constructor in constructors)
            {
                Console.WriteLine($"Constructor: {constructor.Name} = {constructor.Attributes}");
            }
        }
    }
}
