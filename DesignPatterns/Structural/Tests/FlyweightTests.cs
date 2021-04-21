using System.Linq;
using DesignPatterns.Structural.Flyweight;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Structural.Tests
{
    public class FlyweightTests
    {
        [Test]
        public void FlyweightTest()
        {
            // The client code usually creates a bunch of pre-populated
            // flyweights in the initialization stage of the application.
            var factory = new FlyweightFactory(
                new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new Car { Company = "BMW", Model = "M5", Color = "red" },
                new Car { Company = "BMW", Model = "X6", Color = "white" }
            );
            
            factory.ListFlyweights().Count().Should().Be(5);

            AddCarToPoliceDatabase(factory, new Car {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            });

            AddCarToPoliceDatabase(factory, new Car {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "X1",
                Color = "red"
            });

            factory.ListFlyweights().Count().Should().Be(6);
        }
        
        private static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
        {
            var flyweight = factory.GetFlyweight(new Car {
                Color = car.Color,
                Model = car.Model,
                Company = car.Company
            });

            // The client code either stores or calculates extrinsic state and
            // passes it to the flyweight's methods.
            flyweight.Operation(car);
        }
    }
}