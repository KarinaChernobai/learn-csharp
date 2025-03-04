using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApppLearn;
// Reflection in C# is a mechanism that allows you to inspect and manipulate types (classes, methods, properties, etc.) at runtime.
// It is part of the System.Reflection namespace and is useful for dynamically working with objects
// when you do not know their types at compile time.
public class ReflectionDemo
{
    public static void Demonstrate() 
    {
        InspectClass();
        InvokeMethod();
    }
    // Using Reflection to Inspect a Class
    public static void InspectClass()
    {
        Type type = typeof(MyReflectionClass);  // Get type information

        Console.WriteLine($"Class Name: {type.Name}");

        // Get and display properties
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo prop in properties)
        {
            Console.WriteLine($"Property: {prop.Name}, Type: {prop.PropertyType}");
        }

        // Get and display methods
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"Method: {method.Name}");
        }
    }
    // Dynamically Invoking a Method
    public static void InvokeMethod()
    {
        Type type = typeof(MyReflectionClass2);
        object obj = Activator.CreateInstance(type);  // Create instance dynamically

        MethodInfo method = type.GetMethod("Greet");
        // Call method dynamically
        // obj - object instance
        // new object[] { "Karina" } - parameters
        method.Invoke(obj, new object[] { "Karina" }); 
    }
}

public class MyReflectionClass
{
    public string Name { get; set; }
    public void SayHello() => Console.WriteLine("Hello!");
}

public class MyReflectionClass2
{
    public void Greet(string name) => Console.WriteLine($"Hello, {name}!");
}