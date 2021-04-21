using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Facade
{
    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class SubSystem1
    {
        public string Operation1()
        {
            return StructuralText.SubSystem1Ready;
        }

        public string OperationN()
        {
            return StructuralText.SubSystem1Go;
        }
    }
}