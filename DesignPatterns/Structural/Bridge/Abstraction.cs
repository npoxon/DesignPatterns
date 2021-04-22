using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Bridge
{
    // The Abstraction defines the interface for the "control" part of the two
    // class hierarchies. It maintains a reference to an object of the
    // Implementation hierarchy and delegates all of the real work to this
    // object.
    public class Abstraction
    {
        protected readonly IImplementation Implementation;

        public Abstraction(IImplementation implementation)
        {
            Implementation = implementation;
        }

        public virtual string Operation()
        {
            return StructuralText.BaseOperation + Implementation.OperationImplementation();
        }
    }

    // You can extend the Abstraction without changing the Implementation
    // classes.
}