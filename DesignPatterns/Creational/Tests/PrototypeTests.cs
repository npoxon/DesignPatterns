using System;
using DesignPatterns.Creational.Prototype;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    public class PrototypeTests
    {
        [Test]
        public void PrototypeTest()
        {
            const int originalAge = 42;
            var originalBirthDate = Convert.ToDateTime("1977-01-01");
            const string originalName = "Jack Daniels";
            const int originalIdNumber = 666;
            var originalId = new IdInfo(originalIdNumber);
            
            var p1 = new Person
            {
                Age = originalAge,
                BirthDate = originalBirthDate,
                Name = originalName,
                IdInfo = originalId
            };

            // Perform a shallow copy of p1 and assign it to p2.
            var p2 = p1.ShallowCopy();
            // Make a deep copy of p1 and assign it to p3.
            var p3 = p1.DeepCopy();

            // Original values of p1, p2, p3
            p1.Should().BeEquivalentTo(p2);
            p2.Should().BeEquivalentTo(p3);
            
            const int newAge = 32;
            var newBirthDate = Convert.ToDateTime("1900-01-01");
            const string newName = "Frank";
            const int newIdNumber = 7878;
            
            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.Age = newAge;
            p1.BirthDate = newBirthDate;
            p1.Name = newName;
            p1.IdInfo.IdNumber = newIdNumber;

            p1.Age.Should().Be(newAge);
            p1.BirthDate.Should().Be(newBirthDate);
            p1.Name.Should().Be(newName);
            p1.IdInfo.IdNumber.Should().Be(newIdNumber);
            
            // p2 reference values have changed
            p2.Age.Should().Be(originalAge);
            p2.BirthDate.Should().Be(originalBirthDate);
            p2.Name.Should().Be(originalName);
            p2.IdInfo.IdNumber.Should().Be(newIdNumber);
            
            // p3 reference values have not changed
            p3.Age.Should().Be(originalAge);
            p3.BirthDate.Should().Be(originalBirthDate);
            p3.Name.Should().Be(originalName);
            p3.IdInfo.IdNumber.Should().Be(originalIdNumber);
        }
    }
}