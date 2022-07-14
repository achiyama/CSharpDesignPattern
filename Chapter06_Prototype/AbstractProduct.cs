using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06_Prototype.Framework;

namespace Chapter06_Prototype;
public abstract class AbstractProduct
{
    public IProduct CreateClone()
    {
        return (IProduct)MemberwiseClone();
    }
}
