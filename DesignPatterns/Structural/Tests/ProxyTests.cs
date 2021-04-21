using DesignPatterns.Structural.Helpers;
using DesignPatterns.Structural.Proxy;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Structural.Tests
{
    public class ProxyTests
    {
        [Test]
        public void ProxyTest()
        {
            var realSubject = new RealSubject();
            Client.ClientCode(realSubject).Should().Be(StructuralText.SubjectHandlingRequest);

            var proxy = new Proxy.Proxy(realSubject);
            Client.ClientCode(proxy).Should().Be(StructuralText.ProxyHandlingRequest);
        }
    }
}