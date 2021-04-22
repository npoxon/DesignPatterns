namespace DesignPatterns.Behavioral.Mediator
{
    // The Base Component provides the basic functionality of storing a
    // mediator's instance inside component objects.
    public class BaseComponent
    {
        protected IMediator Mediator;

        protected BaseComponent(IMediator mediator = null)
        {
            Mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}