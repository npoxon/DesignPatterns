using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Bridge
{
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return StructuralText.ExtendedOperation + Implementation.OperationImplementation();
        }
    }
}