using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11_Composite;
public abstract class Entry
{
    /// <summary>
    /// 名前を得る
    /// </summary>
    public abstract string Name { get; set; }

    /// <summary>
    /// サイズを得る
    /// </summary>
    public abstract int Size { get; set; }

    public Entry Add(Entry entry)
    {
        throw new FileLoadException();
    }

    public void PrintList()
    {
        PrintList("");
    }

    protected abstract void PrintList(string prefix);

    public override string? ToString()
    {
        return Name + "(" + Size + ")";
    }
}
