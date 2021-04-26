using DesignPatterns.Behavioral.Helpers;

namespace DesignPatterns.Behavioral.State
{
    public class ConcreteStateB : State
    {
        public override string Handle1()
        {
            return BehavioralText.ConcreteStateB;
        }

        public override string Handle2()
        {
            Context.TransitionTo(new ConcreteStateA());
            return BehavioralText.TransitionToA;
        }
    }
}