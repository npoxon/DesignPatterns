using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ReverseStrategy : IStrategy
    {
        public List<string> DoAlgorithm(object data)
        {
            var list = data as List<string>;

            if (!(list?.Count > 0)) return list;
            
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}