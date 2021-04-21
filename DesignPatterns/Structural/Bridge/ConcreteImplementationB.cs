using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Bridge
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return StructuralText.TheResultFromPlatformB;
        }
    }
}