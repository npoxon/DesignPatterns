namespace DesignPatterns.Behavioral.Helpers
{
    public static class BehavioralText
    {
        public const string Banana = "Banana";
        public const string Cheese = "Cheese";
        public const string Meatball = "Meatball";
        public const string Nut = "Nut";

        public static string Dog(string food)
        {
            return $"Dog: I'll eat the {food}";
        }

        public static string Monkey(string food)
        {
            return $"Monkey: I'll eat the {food}";
        }

        public static string Squirrel(string food)
        {
            return $"Squirrel: I'll eat the {food}";
        }

        public static string Untouched(string food)
        {
            return $"{food} was left untouched.";
        }
        
        public const string ConcreteStateA = "ConcreteStateA handles request2.";
        public const string ConcreteStateB = "ConcreteStateB handles request1.";
        public const string TransitionToA = "Transition to A";
        public const string TransitionToB = "Transition to B";
        
        public const string ConcreteClass1Operation1 = "ConcreteClass1 says: Implemented Operation1";
        public const string ConcreteClass1Operation2 = "ConcreteClass1 says: Implemented Operation2";
        public const string ConcreteClass2Operation1 = "ConcreteClass2 says: Implemented Operation1";
        public const string ConcreteClass2Operation2 = "ConcreteClass2 says: Implemented Operation2";
        public const string OverriddenHook = "ConcreteClass2 says: Overridden Hook1";
        public const string BaseOperation1 = "AbstractClass says: I am doing the bulk of the work";
        public const string BaseOperation2 = "AbstractClass says: But I let subclasses override some operations";
        public const string BaseOperation3 = "AbstractClass says: But I am doing the bulk of the work anyway";
    }
}