using System;
using DesignPatterns.Behavioral.Helpers;

namespace DesignPatterns.Behavioral.Template
{
    // Usually, concrete classes override only a fraction of base class'
    // operations.
    public class ConcreteClass2 : AbstractClass
    {
        protected override string RequiredOperations1()
        {
            return BehavioralText.ConcreteClass2Operation1;
        }

        protected override string RequiredOperation2()
        {
            return BehavioralText.ConcreteClass2Operation2;
        }

        protected override void Hook1()
        {
            Console.WriteLine(BehavioralText.OverriddenHook);
        }
    }
}