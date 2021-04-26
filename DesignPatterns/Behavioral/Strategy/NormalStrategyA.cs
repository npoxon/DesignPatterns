using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    public class NormalStrategyA : IStrategy
    {
        public List<string> DoAlgorithm(object data)
        {
            var list = data as List<string>;

            if (list?.Count > 0)
            {
                list.Sort();
            }
            
            return list;
        }
    }
}