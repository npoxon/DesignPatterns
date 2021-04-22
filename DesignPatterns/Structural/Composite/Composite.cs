using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public class Composite : Component
    {
        private readonly List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        // The Composite executes its primary logic in a particular way. It
        // traverses recursively through all its children, collecting and
        // summing their results. Since the composite's children pass these
        // calls to their children and so forth, the whole object tree is
        // traversed as a result.
        public override string Operation()
        {
            var i = 0;
            var result = "Branch(";

            foreach (var component in _children)
            {
                result += component.Operation();
                if (i != _children.Count - 1) result += "+";
                i++;
            }

            return result + ")";
        }
    }
}