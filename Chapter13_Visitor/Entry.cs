using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13_Visitor
{
    public abstract class Entry : IElement
    {
        public abstract string Name { get; }

        public abstract int Size { get; }

        public abstract void Assept(Visitor visitor);

        public override string ToString()
        {
            return Name + "(" + Size + ")";
        }
    }
}