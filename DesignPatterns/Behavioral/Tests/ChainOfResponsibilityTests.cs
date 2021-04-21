#nullable enable
using System.Linq;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Helpers;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class ChainOfResponsibilityTests
    {
        [Test]
        public void ChainOfResponsibilityTest()
        {
            // The other part of the client code constructs the actual chain.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // The client should be able to send a request to any handler, not just the first one in the chain.
            var monkeyResult = Client.ClientCode(monkey);
            var enumerable = monkeyResult as string?[] ?? monkeyResult.ToArray();
            enumerable.Count().Should().Be(3);
            enumerable[0].Should().Be(BehavioralText.Squirrel(BehavioralText.Nut));
            enumerable[1].Should().Be(BehavioralText.Monkey(BehavioralText.Banana));
            enumerable[2].Should().Be(BehavioralText.Untouched(BehavioralText.Cheese));

            var squirrelResult = Client.ClientCode(squirrel);
            enumerable = squirrelResult as string?[] ?? squirrelResult.ToArray();
            enumerable.Count().Should().Be(3);
            enumerable[0].Should().Be(BehavioralText.Squirrel(BehavioralText.Nut));
            enumerable[1].Should().Be(BehavioralText.Untouched(BehavioralText.Banana));
            enumerable[2].Should().Be(BehavioralText.Untouched(BehavioralText.Cheese));
        }
    }
}