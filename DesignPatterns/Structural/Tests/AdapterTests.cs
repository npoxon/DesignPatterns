using DesignPatterns.Common;
using DesignPatterns.Structural.Adapter;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    public class AdapterTests
    {
        [Test]
        public void AdapterTest()
        {
            var adaptee = new Adaptee();
            var target = new Adapter(adaptee);
            target.GetRequest().Should().Be(Text.SpecificText);
        }
    }
}