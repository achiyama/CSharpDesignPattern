using Chapter04_FactoryMethod.Framework;
using System.Collections.Generic;

namespace Chapter04_FactoryMethod.IdCard
{
    class IDCardFactory : Factory
    {
        public List<string> owners { get; }

        public IDCardFactory()
        {
            owners = new List<string>();
        }

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            owners.Add(((IDCard)product)._owner);
        }
    }
}
