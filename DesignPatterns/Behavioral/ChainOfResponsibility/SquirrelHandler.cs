using DesignPatterns.Behavioral.Helpers;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            return request as string == BehavioralText.Nut ? BehavioralText.Squirrel((string) request) : base.Handle(request);
        }
    }
}