using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

public static class ReverseString
{
    public static string ReverseStr(this string str)
    {
        if (str.Length <= 1) return str;
        var arrStr = new char[str.Length];
        for (int i = str.Length - 1, j = 0; i >= 0; i--, j++)
        {
            arrStr[j] = str[i];
        }
        var reversedStr = new String(arrStr);
        return reversedStr;
    }

    public static string ReverseStrOpt(this string str)
    {
        if (str.Length <= 1) return str;
        var reversedStr = String.Create<string>(
            str.Length,
            str,
            static (buffer, s) =>
            {
                for (int i = s.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    buffer[j] = s[i];
                }
            }
        );
        return reversedStr;
    }
}

public ref struct MyClass 
{
    ref int _my_field;
}

public ref struct MyOtherClass 
{
    MyClass my_field;
}