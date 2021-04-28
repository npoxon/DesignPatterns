namespace DesignPatterns.Behavioral.Visitor
{
    public class ConcreteVisitor2 : IVisitor
    {
        public string VisitConcreteComponentA(ConcreteComponentA element)
        {
            return ConcreteComponentA.ExclusiveMethodOfConcreteComponentA();
        }

        public string VisitConcreteComponentB(ConcreteComponentB element)
        {
            return ConcreteComponentB.SpecialMethodOfConcreteComponentB();
        }
    }
}