using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

// Unlike System.String, the StringBuilder class provides a mutable object for text manipulation.
// You can modify its contents without creating a new instance every time.
// This is especially beneficial when performing numerous modifications, such as within loops.
public class StringBuilderDemo
{
    public static void Demonstrate() 
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Hello");
        sb.Append(", World!");
        Console.WriteLine(sb.ToString());  // Outputs: Hello, World!
    }
}
