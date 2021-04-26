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
    }
}