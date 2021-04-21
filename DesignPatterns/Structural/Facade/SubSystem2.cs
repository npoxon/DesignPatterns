using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Facade
{
    // Some facades can work with multiple subsystems at the same time.
    public class SubSystem2
    {
        public string Operation1()
        {
            return StructuralText.SubSystem2Ready;
        }

        public string OperationZ()
        {
            return StructuralText.SubSystem2Fire;
        }
    }
}