using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13_Visitor
{
    /// <summary>
    /// ファイルを表すクラス
    /// </summary>
    public class File : Entry
    {
        public override string Name { get; }
        public override int Size { get; }

        public File(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public override void Assept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
