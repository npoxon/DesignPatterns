using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Visitor
{
    public static class Client
    {
        // The client code can run visitor operations over any set of elements
        // without figuring out their concrete classes. The accept operation
        // directs a call to the appropriate operation in the visitor object.
        public static string ClientCode(IEnumerable<IComponent> components, IVisitor visitor)
        {
            return components.Aggregate(string.Empty, (current, component) => current + component.Accept(visitor));
        }
    }
}