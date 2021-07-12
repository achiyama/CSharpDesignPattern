using Chapter04_FactoryMethod.Framework;
using System.Collections.Generic;

namespace Chapter04_FactoryMethod.IdCard
{
    class IDCardFactory : Factory
    {
        public Dictionary<string, int> owners { get; }
        public int Serial { get; set; } = 100;

        public IDCardFactory()
        {
            owners = new Dictionary<string, int>();
        }

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner, Serial++);
        }

        protected override void RegisterProduct(Product product)
        {
            owners.Add(((IDCard)product)._owner, Serial);
        }
    }
}
