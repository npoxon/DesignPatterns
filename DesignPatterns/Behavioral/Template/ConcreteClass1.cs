using DesignPatterns.Behavioral.Helpers;

namespace DesignPatterns.Behavioral.Template
{
    // Concrete classes have to implement all abstract operations of the base
    // class. They can also override some operations with a default
    // implementation.
    public class ConcreteClass1 : AbstractClass
    {
        protected override string RequiredOperations1()
        {
            return BehavioralText.ConcreteClass1Operation1;
        }

        protected override string RequiredOperation2()
        {
            return BehavioralText.ConcreteClass1Operation2;
        }
    }
}