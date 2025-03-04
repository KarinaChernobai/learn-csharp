using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

// extension methods must be declared in a non-generic static class
public static class ExtensionMethodsDemo
{
    // Extension method to count words in a string
    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;
        return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
    public static void Demonstrate() 
    {
        string sentence = "Hello world, how are you?";
        // Using the extension method as if it were a method on string
        int count = sentence.WordCount();
        Console.WriteLine($"Word count: {count}");
    }
}
