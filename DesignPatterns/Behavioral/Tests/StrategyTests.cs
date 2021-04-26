using DesignPatterns.Behavioral.Strategy;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class StrategyTests
    {
        [Test]
        public void StrategyTest()
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var context = new Context();
            
            context.SetStrategy(new NormalStrategyA());
            context.DoSomeBusinessLogic()[0].Should().Be("a");
            
            context.SetStrategy(new ReverseStrategy());
            context.DoSomeBusinessLogic()[0].Should().Be("e");;
        }
    }
}