using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06_Prototype.Framework;

namespace Chapter06_Prototype;
public class MessageBox : AbstractProduct, IProduct
{
    private readonly char _decochar;

    public MessageBox(char decochar)
    {
        _decochar = decochar;
    }

    public void Use(string s)
    {
        var length = s.Length;
        for (int i = 0; i < length + 4; i++)
        {
            Console.Write(_decochar);
        }
        Console.WriteLine();
        Console.WriteLine(_decochar + " " + s + " " + _decochar);
        for (int i = 0; i < length + 4; i++)
        {
            Console.Write(_decochar);
        }
        Console.WriteLine();
    }
}
