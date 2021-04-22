using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Flyweight
{
    // The Flyweight Factory creates and manages the Flyweight objects. It
    // ensures that flyweights are shared correctly. When the client requests a
    // flyweight, the factory either returns an existing instance or creates a
    // new one, if it doesn't exist yet.
    public class FlyweightFactory
    {
        private readonly List<Tuple<Flyweight, string>> _flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args) _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), GetKey(elem)));
        }

        // Returns a Flyweight's string hash for a given state.
        private static string GetKey(Car key)
        {
            var elements = new List<string> {key.Model, key.Color, key.Company};

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        // Returns an existing Flyweight with a given state or creates a new one.
        public Flyweight GetFlyweight(Car sharedState)
        {
            var key = GetKey(sharedState);

            if (_flyweights.All(t => t.Item2 != key))
                _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));

            return _flyweights.FirstOrDefault(t => t.Item2 == key)?.Item1;
        }

        public IEnumerable<Tuple<Flyweight, string>> ListFlyweights()
        {
            return _flyweights;
        }
    }
}