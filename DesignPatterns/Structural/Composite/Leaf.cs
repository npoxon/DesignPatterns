using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Composite
{
    // The Leaf class represents the end objects of a composition. A leaf can't
    // have any children.
    //
    // Usually, it's the Leaf objects that do the actual work, whereas Composite
    // objects only delegate to their sub-components.

    // The Composite class represents the complex components that may have
    // children. Usually, the Composite objects delegate the actual work to
    // their children and then "sum-up" the result.
    public class Leaf : Component
    {
        public override string Operation()
        {
            return StructuralText.Leaf;
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}