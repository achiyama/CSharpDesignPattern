using Chapter04_FactoryMethod.Framework;
using System.Collections.Generic;

namespace Chapter04_FactoryMethod.Television
{
    public class TelevisionFactory : Factory
    {
        public List<string> _manufacturers { get; }

        public TelevisionFactory()
        {
            _manufacturers = new List<string>();
        }

        protected override Product CreateProduct(string manufacturer)
        {
            return new Television(manufacturer);
        }

        protected override void RegisterProduct(Product product)
        {
            _manufacturers.Add(((Television)product)._manufacturer);
        }
    }
}
