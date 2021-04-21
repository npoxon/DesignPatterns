#nullable enable
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Behavioral.Helpers;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public static class Client
    {
        // The client code is usually suited to work with a single handler. In
        // most cases, it is not even aware that the handler is part of a chain.
        public static IEnumerable<string?> ClientCode(AbstractHandler handler)
        {
            return (from food in new List<string> {BehavioralText.Nut, BehavioralText.Banana, BehavioralText.Cheese} 
                let result = handler.Handle(food) select result != null 
                    ? result.ToString() 
                    : BehavioralText.Untouched(food)).ToList();
        }
    }
}