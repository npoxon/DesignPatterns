using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Helpers;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Structural.Tests
{
    public class FacadeTests
    {
        [Test]
        public void FacadeTest()
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            var subsystem1 = new SubSystem1();
            var subsystem2 = new SubSystem2();
            var facade = new Facade.Facade(subsystem1, subsystem2);
            Client.ClientCode(facade).Should().Be(StructuralText.FacadeResult);
        } 
    }
}