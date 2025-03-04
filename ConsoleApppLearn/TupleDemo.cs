using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

// In C#, a tuple is a lightweight data structure
// that groups multiple values into a single compound value without having to define a custom type. 
public class TupleDemo
{
    public static void Demonstrate() 
    {
        // Creating a tuple with System.ValueTuple
        var person = (Id: 1, Name: "Alice");

        // Accessing elements
        Console.WriteLine(person.Id);   // Outputs: 1
        Console.WriteLine(person.Name); // Outputs: Alice

        // Deconstructing a tuple
        var (id, name) = person;
        Console.WriteLine(id);   // Outputs: 1
        Console.WriteLine(name); // Outputs: Alice

    }
}
