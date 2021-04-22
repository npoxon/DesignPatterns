using DesignPatterns.Behavioral.Helpers;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            return request as string == BehavioralText.Banana
                ? BehavioralText.Monkey((string) request)
                : base.Handle(request);
        }
    }
}