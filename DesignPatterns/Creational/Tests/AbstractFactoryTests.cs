using DesignPatterns.Creational;
using DesignPatterns.Creational.AbstractFactory;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    public class AbstractFactoryTests
    {
        private static IAbstractProductA _productA;
        private static IAbstractProductB _productB;

        [Test]
        public void AbstractFactoryTest()
        {
            // The client code can work with any concrete factory class.
            const int firstExpectedResult = 2;
            ClientMethod(new ConcreteFactory1());
            _productA.AddingFunction(1).Should().Be(firstExpectedResult);
            _productB.UsefulFunctionB().Should().Be(Text.ResultB1);
            _productB.AnotherUsefulFunctionB(_productA).Should().Be(Text.WithTheResultFromTheFirstFunction(firstExpectedResult));

            const int secondExpectedResult = 3;
            ClientMethod(new ConcreteFactory2());
            _productA.AddingFunction(1).Should().Be(secondExpectedResult);
            _productB.UsefulFunctionB().Should().Be(Text.ResultB2);
            _productB.AnotherUsefulFunctionB(_productA).Should().Be(Text.WithTheResultFromTheSecondFunction(secondExpectedResult));
        }
        
        private static void ClientMethod(IAbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }
    }
}