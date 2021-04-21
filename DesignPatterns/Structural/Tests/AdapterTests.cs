using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Helpers;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Structural.Tests
{
    public class AdapterTests
    {
        [Test]
        public void AdapterTest()
        {
            var adaptee = new Adaptee();
            var target = new Adapter.Adapter(adaptee);
            target.GetRequest().Should().Be(StructuralText.SpecificText);
        }
    }
}