using DesignPatterns.Behavioral.Memento;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class MementoTests
    {
        [Test]
        public void MementoTest()
        {
            const string originalState = "Super-duper-super-puper-super.";
            // Client code.
            var originator = new Originator(originalState);
            var caretaker = new Caretaker(originator);
            
            caretaker.Backup();
            var a = originator.DoSomething();
            
            caretaker.Backup();
            var b = originator.DoSomething();

            caretaker.Backup();
            
            var history = caretaker.ShowHistory();
            history.Count.Should().Be(3);
            history[0].Should().Contain(originalState);
            history[1].Should().Contain(a);
            history[2].Should().Contain(b);

            caretaker.Undo();
            
            history = caretaker.ShowHistory();
            history.Count.Should().Be(2);
            history[0].Should().Contain(originalState);
            history[1].Should().Contain(a);
            
            caretaker.Undo();
            
            history = caretaker.ShowHistory();
            history.Count.Should().Be(1);
            history[0].Should().Contain(originalState);
        }
    }
}