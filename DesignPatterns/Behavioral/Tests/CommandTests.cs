using DesignPatterns.Behavioral.Command;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class CommandTests
    {
        [Test]
        public void CommandTest()
        {
            // The client code can parameterize an invoker with any commands.
            var invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            var receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));
            invoker.DoSomethingImportant().Should().Be("Save report");
        }
    }
}