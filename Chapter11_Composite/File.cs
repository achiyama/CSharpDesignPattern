using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11_Composite;
public class File : Entry
{
    public override string Name { get; set; }

    public override int Size { get; set; }

    public File(string name, int size)
    {
        Name = name;
        Size = size;
    }

    protected override void PrintList(string prefix)
    {
        Console.WriteLine(prefix + "/" + this);
    }
}
