namespace DesignPatterns.Behavioral.Mediator
{
    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    public class Component1 : BaseComponent
    {
        public string DoA()
        {
            return Mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Mediator.Notify(this, "B");
        }
    }
}