namespace DesignPatterns.Structural.Decorator
{
    // The base Decorator class follows the same interface as the other
    // components. The primary purpose of this class is to define the wrapping
    // interface for all concrete decorators. The default implementation of the
    // wrapping code might include a field for storing a wrapped component and
    // the means to initialize it.
    public abstract class Decorator : Component
    {
        private readonly Component _component;

        protected Decorator(Component component)
        {
            _component = component;
        }

        // The Decorator delegates all work to the wrapped component.
        public override string Operation()
        {
            return _component != null ? _component.Operation() : string.Empty;
        }
    }
}