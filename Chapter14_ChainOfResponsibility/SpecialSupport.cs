using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_ChainOfResponsibility;
public class SpecialSupport : SupportBase
{
    private int _number;

    public SpecialSupport(string name, int number) : base(name)
    {
        _number = number;
    }

    protected override bool Resolve(Trouble trouble)
        => trouble.Number == _number;
}
