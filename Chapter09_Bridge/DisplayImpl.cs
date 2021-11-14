using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09_Bridge
{
    /// <summary>
    /// 実装のクラスの最上位
    /// </summary>
    public abstract class DisplayImpl
    {
        public abstract void RawOpen();

        public abstract void RawPrint();

        public abstract void RawClose();
    }
}
