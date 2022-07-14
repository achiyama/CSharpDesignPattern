using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06_Prototype.Framework;
public class Manager
{
    private Dictionary<string, IProduct> _showcasae = new Dictionary<string, IProduct>();

    public void Register(string name, IProduct proto)
    {
        _showcasae.Add(name, proto);
    }

    public IProduct Create(string protoname)
        => _showcasae[protoname].CreateClone();
}
