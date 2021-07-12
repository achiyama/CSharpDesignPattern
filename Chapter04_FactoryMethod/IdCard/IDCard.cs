using Chapter04_FactoryMethod.Framework;
using System;

namespace Chapter04_FactoryMethod.IdCard
{
    public class IDCard : Product
    {
        public string _owner { get; }
        public int _serial;

        public IDCard(string owner, int serial)
        {
            Console.WriteLine(owner + "(" + serial + ")のカードを作ります。");
            _owner = owner;
            _serial = serial;
        }

        public override void Use()
        {
            Console.WriteLine(_owner + "(" + _serial + ")のカードを使います。");
        }
    }
}
