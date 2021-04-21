namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteProductAThatAdds1 : IAbstractProductA
    {
        public int AddingFunction(int value)
        {
            return value + 1;
        }
    }
}