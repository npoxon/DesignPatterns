using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Helpers;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Structural.Tests
{
    public class CompositeTests
    {
        [Test]
        public void CompositeTest()
        {
            // This way the client code can support the simple leaf components...
            var leaf = new Leaf();
            Client.ClientCode(leaf).Should().Be(StructuralText.Leaf);

            // ...as well as the complex composites.
            var tree = new Composite.Composite();
            var branch1 = new Composite.Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            var branch2 = new Composite.Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Client.ClientCode(tree).Should().Be(StructuralText.CompositeResultA);
            Client.ClientCode2(tree, leaf).Should().Be(StructuralText.CompositeResultB);
        }
    }
}