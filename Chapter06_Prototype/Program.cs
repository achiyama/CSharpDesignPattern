using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06_Prototype.Framework;

namespace Chapter06_Prototype;
public class Program
{
    public static void Main(string[] args)
    {
        var manager = new Manager();
        var upen = new UnderlinePen('~');
        var mbox = new MessageBox('*');
        var sbox = new MessageBox('/');

        manager.Register("strong message", upen);
        manager.Register("warning box", mbox);
        manager.Register("slash box", sbox);

        var p1 = manager.Create("strong message");
        p1.Use("Hello, World");
        var p2 = manager.Create("warning box");
        p2.Use("Hello, World");
        var p3 = manager.Create("slash box");
        p3.Use("Hello, World");
    }
}
