namespace DesignPatterns.Behavioral.Mediator
{
    // Concrete Mediators implement cooperative behavior by coordinating several
    // components.
    public class ConcreteMediator : IMediator
    {
        private readonly Component1 _component1;

        private readonly Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);
            _component2 = component2;
            _component2.SetMediator(this);
        } 

        public string Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "A":
                    _component2.DoC();
                    return ev;
                case "D":
                    _component1.DoB();
                    _component2.DoC();
                    return ev;
            }
            return string.Empty;
        }
    }
}