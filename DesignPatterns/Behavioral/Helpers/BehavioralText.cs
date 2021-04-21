namespace DesignPatterns.Behavioral.Helpers
{
    public static class BehavioralText
    {
        public static string Dog(string food) => $"Dog: I'll eat the {food}";
        public static string Monkey(string food) => $"Monkey: I'll eat the {food}";
        public static string Squirrel(string food) => $"Squirrel: I'll eat the {food}";
        public static string Untouched(string food) => $"{food} was left untouched.";
        public const string Banana = "Banana";
        public const string Cheese = "Cheese";
        public const string Meatball = "Meatball";
        public const string Nut = "Nut";
    }
}