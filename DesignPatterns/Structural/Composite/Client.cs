namespace DesignPatterns.Structural.Composite
{
    public static class Client
    {
        // The client code works with all of the components via the base
        // interface.
        public static string ClientCode(Component leaf)
        {
            return leaf.Operation();
        }

        // Thanks to the fact that the child-management operations are declared
        // in the base Component class, the client code can work with any
        // component, simple or complex, without depending on their concrete
        // classes.
        public static string ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }
            
            return component1.Operation();
        }
    }
}