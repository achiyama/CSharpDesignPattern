using Chapter04_FactoryMethod.Framework;
using System;

namespace Chapter04_FactoryMethod.IdCard
{
    public class IDCard : Product
    {
        public string _owner { get; }

        public IDCard(string owner)
        {
            Console.WriteLine(owner + "のカードを作ります。");
            _owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine(_owner + "のカードを使います。");
        }
    }
}
