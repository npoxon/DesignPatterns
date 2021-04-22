using System.Collections.Generic;
using DesignPatterns.Behavioral.Iterator;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.Behavioral.Tests
{
    public class IteratorTests
    {
        [Test]
        public void IteratorTest()
        {
            // The client code may or may not know about the Concrete Iterator
            // or Collection classes, depending on the level of indirection you
            // want to keep in your program.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            collection.Should().Equal(new List<string> {"First", "Second", "Third"});

            collection.ReverseDirection();

            collection.Should().Equal(new List<string> {"Third", "Second", "First"});
        }
    }
}