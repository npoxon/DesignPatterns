using DesignPatterns.Structural.Helpers;

namespace DesignPatterns.Structural.Facade
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class Facade
    {
        private readonly SubSystem1 _subsystem1;

        private readonly SubSystem2 _subsystem2;

        public Facade(SubSystem1 subsystem1, SubSystem2 subsystem2)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            var result = StructuralText.FacadeSubInitialise;
            result += _subsystem1.Operation1();
            result += _subsystem2.Operation1();
            result += StructuralText.FacadeOrdersAction;
            result += _subsystem1.OperationN();
            result += _subsystem2.OperationZ();
            return result;
        }
    }
}