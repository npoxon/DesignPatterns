namespace DesignPatterns.Creational.Helpers
{
    public static class Text
    {
        public const string ResultB1 = "The result of the product B1.";
        public const string ResultB2 = "The result of the product B2.";
        public const string PartA = "Part A";
        public const string PartB = "Part B";
        public const string PartC = "Part C";

        public static string WithTheResultFromTheFirstFunction(int result)
        {
            return $"The result of the B1 collaborating with the ({result})";
        }

        public static string WithTheResultFromTheSecondFunction(int result)
        {
            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}