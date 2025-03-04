using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

// Define a delegate type that takes a string parameter and returns void.
public delegate void Notify(string message);

public class Process
{
    // A method that matches the delegate signature.
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}

public class DelegateDemo
{
    public static void Demonstrate() 
    {
        Process process = new Process();
        // Create a delegate instance pointing to the ShowMessage method.
        Notify notifier = process.ShowMessage;
        // Invoke the delegate.
        notifier("Hello, Delegates!");
    }
}
