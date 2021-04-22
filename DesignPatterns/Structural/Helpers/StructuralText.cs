namespace DesignPatterns.Structural.Helpers
{
    public static class StructuralText
    {
        public const string BaseOperation = "Base operation with ";
        public const string CompositeResultA = "Branch(Branch(Leaf+Leaf)+Branch(Leaf))";
        public const string CompositeResultB = "Branch(Branch(Leaf+Leaf)+Branch(Leaf)+Leaf)";
        public const string ConcreteComponent = "ConcreteComponent";
        public const string ConcreteDecoratorA = "ConcreteDecoratorA";
        public const string ConcreteDecoratorB = "ConcreteDecoratorB";
        public const string FacadeSubInitialise = "Facade initializes subsystems: ";
        public const string FacadeOrdersAction = "Facade orders subsystems to perform the action: ";

        public const string FacadeResult =
            "Facade initializes subsystems: Subsystem1: Ready!Subsystem2: Ready!Facade orders subsystems to perform the action: Subsystem1: Go!Subsystem2: Fire!";

        public const string ExtendedOperation = "Extended operation with ";
        public const string Leaf = "Leaf";
        public const string ProxyHandlingRequest = "Proxy: Handling Request.";
        public const string SpecificText = "Specific Text";
        public const string SubjectHandlingRequest = "RealSubject: Handling Request.";
        public const string SubSystem1Ready = "Subsystem1: Ready!";
        public const string SubSystem1Go = "Subsystem1: Go!";
        public const string SubSystem2Ready = "Subsystem2: Ready!";
        public const string SubSystem2Fire = "Subsystem2: Fire!";
        public const string TheResultFromPlatformA = "the result in platform A";
        public const string TheResultFromPlatformB = "the result in platform B";
    }
}