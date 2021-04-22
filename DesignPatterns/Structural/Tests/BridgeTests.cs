using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Helpers;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Structural.Tests
{
    public class BridgeTests
    {
        [Test]
        public void BridgeTest()
        {
            var client = new Client();

            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            var abstractionA = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstractionA).Should()
                .Be(StructuralText.BaseOperation + StructuralText.TheResultFromPlatformA);

            var abstractionB = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstractionB).Should()
                .Be(StructuralText.ExtendedOperation + StructuralText.TheResultFromPlatformB);
        }
    }
}