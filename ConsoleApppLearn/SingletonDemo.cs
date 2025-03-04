using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;
// The Singleton design pattern ensures that a class has only one instance and provides a global access point to that instance.
// It is commonly used for logging, configuration management, thread pools, and database connections.
// Basic Singleton Implementation (Thread-Unsafe)
public class Singleton
{
    private static Singleton instance;  // Holds the single instance

    private Singleton() { }  // Private constructor prevents external instantiation

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}

public class SingletonDemo
{
    public static void Demonstrate() 
    {
        Singleton.GetInstance();
    }
}

/*We can implement a singleton design pattern in C# using:

No Thread Safe Singleton.
Thread-Safety Singleton.
Thread-Safety Singleton using Double-Check Locking.
Thread-safe without a lock.
Using.NET 4’s Lazy<T> type.

*/