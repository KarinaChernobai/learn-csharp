using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

public class IteratorDemo
{
    public static IEnumerable<int> MyIterator(int from, int to) // coroutine
    {
        if (from == to) yield break;
        if (from < to) 
        {
            for (int i = from; i < to; i++)
            {
                Console.WriteLine($"About to yield {i}");
                yield return i;
                Console.WriteLine($"Yielded {i}");
            }
        }
        else 
        {
            for (int i = from; i > to; i--)
            {
                Console.WriteLine($"About to yield {i}");
                yield return i;
                Console.WriteLine($"Yielded {i}");
            }
        }
    }
}
