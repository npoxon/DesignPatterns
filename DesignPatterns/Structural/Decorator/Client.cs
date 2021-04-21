namespace DesignPatterns.Structural.Decorator
{
    public static class Client
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public static string ClientCode(Component component)
        {
            return component.Operation();
        }
    }
}