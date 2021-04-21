namespace DesignPatterns.Structural.Bridge
{
    public class Client
    {
        // Except for the initialization phase, where an Abstraction object gets
        // linked with a specific Implementation object, the client code should
        // only depend on the Abstraction class. This way the client code can
        // support any abstraction-implementation combination.
        public string ClientCode(Abstraction abstraction)
        {
            return abstraction.Operation();
        }
    }
}