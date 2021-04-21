namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteProductAThatAdds2 : IAbstractProductA
    {
        public int AddingFunction(int value)
        {
            return value + 2;
        }
    }
}