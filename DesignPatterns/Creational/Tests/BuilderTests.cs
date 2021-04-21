using DesignPatterns.Creational;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    public class BuilderTests
    {
        [Test]
        public void BuilderTest()
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;
            
            // Create a standard basic product
            director.BuildMinimalViableProduct();
            builder.GetProduct().ListParts().Should().ContainInOrder(Text.PartA);

            // Create a standard full featured product
            director.BuildFullFeaturedProduct();
            builder.GetProduct().ListParts().Should().ContainInOrder(Text.PartA, Text.PartB, Text.PartC);

            // Remember, the Builder pattern can be used without a Director
            // class.
            builder.BuildPartA();
            builder.BuildPartC();
            builder.GetProduct().ListParts().Should().ContainInOrder(Text.PartA, Text.PartC);
        }
    }
}