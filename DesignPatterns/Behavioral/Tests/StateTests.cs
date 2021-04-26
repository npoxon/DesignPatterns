using DesignPatterns.Behavioral.Helpers;
using DesignPatterns.Behavioral.State;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class StateTests
    {
        [Test]
        public void StateTest()
        {
            // The client code.
            var context = new Context(new ConcreteStateA());
            context.Request1().Should().Be(BehavioralText.TransitionToB);
            context.Request2().Should().Be(BehavioralText.TransitionToA);
        }
    }
}