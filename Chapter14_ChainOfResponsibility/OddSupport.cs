using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_ChainOfResponsibility;

public class OddSupport : SupportBase
{
    public OddSupport(string name) : base(name)
    {
    }

    protected override bool Resolve(Trouble trouble)
        => trouble.Number % 2 == 1;
}
