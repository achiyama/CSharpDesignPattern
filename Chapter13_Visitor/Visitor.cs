using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13_Visitor
{
    /// <summary>
    /// ファイルやディレクトリを訪れる訪問者を表す抽象クラス
    /// </summary>
    public abstract class Visitor
    {
        public abstract void Visit(File file);
        public abstract void Visit(Directory directory);
    }
}
