using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

public class InterfaceDemo : IInterfaceDemo
{
    public static void Demonstrate()
    {
        throw new NotImplementedException();
    }

    public void PublicMethodDemo() 
    {
        // is not seen by the class
        // ProtectedMethodDemo();

        Console.WriteLine("InterfaceDemo.PublicMethodDemo");
    }
}

// An interface defines a contract.
// It is used to implement the peripheral abilities of the class.
public interface IInterfaceDemo 
{
    // defines a static constructor
    // interfaces cannot define instance constructors
    static IInterfaceDemo() { }

    // an interface may declare static abstract and static virtual members for all member types except fields.
    static abstract void Demonstrate();

    // will be seen only in interfaces that implement IInterfaceDemo but not in the class 
    protected void ProtectedMethodDemo() 
    {
        Console.WriteLine("ProtectedMethodDemo");
    }
    void PublicMethodDemo()
    {
        Console.WriteLine("IInterfaceDemo.PublicMethodDemo");
    }
}