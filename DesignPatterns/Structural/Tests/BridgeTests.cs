using DesignPatterns.Common;
using DesignPatterns.Structural.Bridge;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Tests
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
            client.ClientCode(abstractionA).Should().Be(Text.BaseOperation + Text.TheResultFromPlatformA);
            
            var abstractionB = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstractionB).Should().Be(Text.ExtendedOperation + Text.TheResultFromPlatformB);
        }
    }
}