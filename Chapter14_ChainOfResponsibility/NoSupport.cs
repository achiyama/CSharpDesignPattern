using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_ChainOfResponsibility;

public class NoSupport : SupportBase
{
    public NoSupport(string name) : base(name)
    {
    }

    protected override bool Resolve(Trouble trouble)
        => false;
}
