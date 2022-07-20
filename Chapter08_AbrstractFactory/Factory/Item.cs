using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08_AbrstractFactory.Factory;

public abstract class Item
{
    protected string _caption;

    public Item(string caption)
    {
        _caption = caption;
    }

    public abstract string MakeHtml();
}
