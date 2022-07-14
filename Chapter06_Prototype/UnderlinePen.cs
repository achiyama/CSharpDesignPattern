using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06_Prototype.Framework;

namespace Chapter06_Prototype;

public class UnderlinePen : AbstractProduct, IProduct
{
    private char _ulchar;

    public UnderlinePen(char ulchar)
    {
        _ulchar = ulchar;
    }

    public void Use(string s)
    {
        var length = s.Length;
        Console.Write("\"" + s + "\"");
        Console.WriteLine();
        for (var i = 0; i < length; i++)
        {
            Console.Write(_ulchar);
        }
        Console.WriteLine();
    }
}
