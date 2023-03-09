using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14_ChainOfResponsibility;

/// <summary>
/// サポートクラス
/// </summary>
public abstract class SupportBase
{
    private string _name;

    private SupportBase _next;

    public SupportBase(string name)
    {
        _name = name;
    }

    /// <summary>
    /// たらい回しの先を設定
    /// </summary>
    /// <param name="next"></param>
    /// <returns></returns>
    public SupportBase setNext(SupportBase next)
    {
        _next = next;
        return _next;
    }

    /// <summary>
    /// 解決
    /// </summary>
    /// <param name="trouble"></param>
    /// <returns></returns>
    protected abstract bool Resolve(Trouble trouble);

    /// <summary>
    /// トラブル解決の手順
    /// </summary>
    public void Support(Trouble trouble)
    {
        if (Resolve(trouble))
        {
            Done(trouble);
        }
        else if (_next != null)
        {
            _next.Support(trouble);
        }
        else
        {
            Fail(trouble);
        }
    }

    protected void Done(Trouble trouble)
    {
        Console.WriteLine($"{trouble} is resolved by {this}");
    }

    protected void Fail(Trouble trouble)
    {
        Console.WriteLine($"{trouble} cannot be resolved.");
    }

    public override string? ToString()
    {
        return $"[{_name}]";
    }
}
