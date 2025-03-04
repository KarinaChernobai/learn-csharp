using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

public class IndexersDemo
{
    public static void Demonstrate() 
    {
        var collection = new SampleCollection<string>();
        collection[0] = "Hello, Indexers!";
        Console.WriteLine(collection[0]);  // Outputs: Hello, Indexers!
    }
}

public class SampleCollection<T>
{
    private T[] items = new T[100];

    // Indexer declaration
    public T this[int index]
    {
        get
        {
            // Add bounds checking if necessary
            return items[index];
        }
        set
        {
            // Add bounds checking if necessary
            items[index] = value;
        }
    }
}
