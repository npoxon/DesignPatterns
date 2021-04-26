using DesignPatterns.Behavioral.Helpers;

namespace DesignPatterns.Behavioral.State
{
// Concrete States implement various behaviors, associated with a state of
    // the Context.
    public class ConcreteStateA : State
    {
        public override string Handle1()
        {
            Context.TransitionTo(new ConcreteStateB());
            return BehavioralText.TransitionToB;
        }

        public override string Handle2()
        {
            return BehavioralText.ConcreteStateA;
        }
    }
}