using DesignPatterns.Behavioral.Helpers;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            return request as string == BehavioralText.Meatball
                ? BehavioralText.Dog((string) request)
                : base.Handle(request);
        }
    }
}