using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13_Visitor
{
    /// <summary>
    /// ディレクトリを表すクラス
    /// </summary>
    public class Directory : Entry
    {
        /// <summary>
        /// ディレクトリの名前
        /// </summary>
        public override string Name { get; }

        /// <summary>
        /// ディレクトリエントリの名前
        /// </summary>
        public List<Entry> Directories { get; set; } = new List<Entry>();

        /// <summary>
        /// サイズを得る
        /// </summary>
        public override int Size { get; }

        public override void Assept(Visitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
