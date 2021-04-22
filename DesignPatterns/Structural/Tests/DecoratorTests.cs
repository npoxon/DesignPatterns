using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Helpers;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Structural.Tests
{
    public class DecoratorTests
    {
        [Test]
        public void DecoratorTest()
        {
            var simple = new ConcreteComponent();
            Client.ClientCode(simple).Should().Be(StructuralText.ConcreteComponent);

            // Note how decorators can wrap not only simple components but the other decorators as well.
            var decorator1 = new ConcreteDecoratorA(simple);
            var decorator2 = new ConcreteDecoratorB(decorator1);
            Client.ClientCode(decorator2).Should().Be(StructuralText.ConcreteDecoratorB +
                                                      StructuralText.ConcreteDecoratorA +
                                                      StructuralText.ConcreteComponent);
        }
    }
}