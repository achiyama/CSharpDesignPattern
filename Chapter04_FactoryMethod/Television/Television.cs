using Chapter04_FactoryMethod.Framework;
using System;

namespace Chapter04_FactoryMethod.Television
{
    public class Television : Product
    {
        public string _manufacturer;

        public Television(string manufacturer)
        {
            _manufacturer = manufacturer;
        }

        public override void Use()
        {
            Console.WriteLine(_manufacturer + "のテレビを利用しました。");
        }
    }
}
