using DesignPatterns.Behavioral.Template;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class TemplateTests
    {
        [Test]
        public void TemplateTest()
        {
            Client.ClientCode(new ConcreteClass1());
            
            // Same client code can work with different subclasses
            Client.ClientCode(new ConcreteClass2());
        }
    }
}