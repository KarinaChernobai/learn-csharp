using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

// Multithreading in .NET refers to the ability of an application to execute multiple threads concurrently,
// allowing several operations to run in parallel within a single process.
// This can lead to improved responsiveness and performance,
// especially in applications that handle long-running or blocking operations.
public class MultithreadingDemo
{
    public static void Demonstrate() 
    {
        // Create and run a task that performs some work in parallel
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Task iteration {i}");
                Task.Delay(500).Wait(); // Simulate work
            }
        });

        // Main thread continues executing
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main iteration {i}");
            Task.Delay(500).Wait(); // Simulate work
        }

        // Wait for the task to complete before exiting
        task.Wait();
    }
}
