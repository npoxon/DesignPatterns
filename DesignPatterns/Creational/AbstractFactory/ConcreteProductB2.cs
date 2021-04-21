namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return Text.ResultB2;
        }

        // The variant, Product B2, is only able to work correctly with the
        // variant, Product A2. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.AddingFunction(1);
            return Text.WithTheResultFromTheSecondFunction(result);
        }
    }
}