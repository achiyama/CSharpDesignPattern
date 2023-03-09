using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_ChainOfResponsibility;

public class LimitSupport : SupportBase
{
    /// <summary>
    /// この番号未満なら解決可能
    /// </summary>
    private int _limit;

    public LimitSupport(string name, int limit) : base(name)
    {
        _limit = limit;
    }

    protected override bool Resolve(Trouble trouble)
        => trouble.Number < _limit;
}
