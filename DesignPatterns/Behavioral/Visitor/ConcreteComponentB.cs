namespace DesignPatterns.Behavioral.Visitor
{
    public class ConcreteComponentB : IComponent
    {
        // Same here: VisitConcreteComponentB => ConcreteComponentB
        public string Accept(IVisitor visitor)
        {
            return visitor.VisitConcreteComponentB(this);
        }

        public static string SpecialMethodOfConcreteComponentB()
        {
            return "B";
        }
    }
}