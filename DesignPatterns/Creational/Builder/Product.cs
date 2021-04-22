using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder
{
    // It makes sense to use the Builder pattern only when your products are
    // quite complex and require extensive configuration.
    //
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class Product
    {
        private readonly List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public IEnumerable<string> ListParts()
        {
            return _parts;
        }
    }
}