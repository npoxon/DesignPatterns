using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Bridge
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return StructuralText.TheResultFromPlatformA;
        }
    }
}