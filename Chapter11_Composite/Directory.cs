using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11_Composite;

internal class Directory : Entry
{
    public override string Name { get {
            return ""; } }

    public override int Size { get; set; }


    protected override void PrintList(string prefix)
    {
        throw new NotImplementedException();
    }
}
