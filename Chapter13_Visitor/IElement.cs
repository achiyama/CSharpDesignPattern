using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13_Visitor
{
    /// <summary>
    /// Visitorクラスのインスタンスを受け入れるデータ構造を表すインターフェース
    /// </summary>
    public interface IElement
    {
        public abstract void Assept(Visitor visitor);
    }
}
