using System.Collections.Generic;
using DesignPatterns.Behavioral.Visitor;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class VisitorTests
    {
        [Test]
        public void VisitorTest()
        {
            var components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            // The client code works with all visitors via the base Visitor interface
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components,visitor1).Should().Be("AB");
            
            // It allows the same client code to work with different types of visitors
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2).Should().Be("AB");
        }
    }
}