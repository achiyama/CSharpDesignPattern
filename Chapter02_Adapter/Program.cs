using Chapter02_Adapter.Inheritance;
using Chapter02_Adapter.Delegation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_Adapter;

public class Program
{
    public static void Main()
    {
        // 継承バージョン
        Inheritance.IPrint ip = new Inheritance.PrintBanner("Hello");
        ip.PrintWeak();
        ip.PrintStrong();

        // 委譲バージョン
        Delegation.Print dp = new Delegation.PrintBanner("Hello");
        dp.PrintWeak();
        dp.PrintStrong();
    }
}
