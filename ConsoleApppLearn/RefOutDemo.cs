using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

class RefOutDemo
{
    public void MyMethod1() 
    {
        var num = 4;
        MyMethod2(ref num, out var num2);
    }

    public void MyMethod2(ref int param1, out int param2)
    {
        var f = param1;
        param1 = 3; // можно не менять, по моему усмотрению
        param2 = 1; // обязательно нужно инициализировать до завершения метода
    }
}

class ConstDemo 
{
    public const int _my_field = 9;

    public void MyMethod() 
    {
        var constDemo = new ConstDemo();
        var hs = ConstDemo._my_field;
        // var hs2 = constDemo._my_field; -- not allowed
        const int num = 3;
    }
}