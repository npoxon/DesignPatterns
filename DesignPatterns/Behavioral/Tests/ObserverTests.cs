using DesignPatterns.Behavioral.Observer;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class ObserverTests
    {
        [Test]
        public void ObserverTest()
        {
            // The client code.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic().Should().BeInRange(0, 10);
            subject.SomeBusinessLogic().Should().BeInRange(0, 10);

            subject.Detach(observerB);

            subject.SomeBusinessLogic().Should().BeInRange(0, 10);
        }
    }
}