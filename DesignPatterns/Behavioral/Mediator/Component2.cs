namespace DesignPatterns.Behavioral.Mediator
{
    public class Component2 : BaseComponent
    {
        public string DoC()
        {
            return Mediator.Notify(this, "C");
        }

        public string DoD()
        {
            return Mediator.Notify(this, "D");
        }
    }
}