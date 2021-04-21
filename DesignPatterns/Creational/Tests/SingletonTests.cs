using System.Threading;
using DesignPatterns.Creational.Singleton;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    public class SingletonTests
    {
        [Test]
        public void SingletonTest()
        {
            // The client code.
            var s1 = SingletonPattern.GetInstance();
            var s2 = SingletonPattern.GetInstance();
            
            s1.Should().Be(s2);
            s1.DoSomeBusinessLogic();
        }

        [Test]
        public void ThreadSafeSingletonTest()
        {
            var process1 = new Thread(() =>
            {
                ThreadSafeSingleton.GetInstance("FOO");
            });
            
            var process2 = new Thread(() =>
            {
                ThreadSafeSingleton.GetInstance("BAR").Value.Should().Be("FOO");;
            });
            
            process1.Start();
            process2.Start();
            
            process1.Join();
            process2.Join();
        }
    }
}