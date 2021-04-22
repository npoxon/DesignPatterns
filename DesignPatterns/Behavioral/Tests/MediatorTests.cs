using DesignPatterns.Behavioral.Mediator;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class MediatorTests
    {
        [Test]
        public void MediatorTest()
        {
            // The client code.
            var component1 = new Component1();
            var component2 = new Component2();
            new ConcreteMediator(component1, component2);
            component1.DoA().Should().Be("A");
            component2.DoD().Should().Be("D");;
        }
    }
}