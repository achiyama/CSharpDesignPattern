using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_ChainOfResponsibility;

public class Trouble
{
    /// <summary>
    /// トラブル番号
    /// </summary>
    public int Number { get; }

    public Trouble(int number)
    {
        Number = number;
    }

    public override string? ToString()
    {
        return $"[Trouble {Number}]";
    }
}
