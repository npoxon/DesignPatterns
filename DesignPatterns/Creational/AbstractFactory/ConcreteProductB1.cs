namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return Text.ResultB1;
        }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.AddingFunction(1);
            return Text.WithTheResultFromTheFirstFunction(result);
        }
    }
}