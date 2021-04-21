using DesignPatterns.Creational.Factory;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Creational.Tests
{
    public class FactoryTests
    {
        [Test]
        public void FactoryTest()
        {
            const int originalValue = 1;

            ClientCode(new ConcreteCreatorThatAdds1(), originalValue).Should().Be(originalValue + 1);
            ClientCode(new ConcreteCreatorThatAdds2(), originalValue).Should().Be(originalValue + 2);
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        private static int ClientCode(Creator creator, int value)
        {
            return creator.SomeOperation(value);
        }
    }
}