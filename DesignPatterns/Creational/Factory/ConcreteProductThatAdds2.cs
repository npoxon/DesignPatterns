namespace DesignPatterns.Creational.Factory
{
    public class ConcreteProductThatAdds2 : IProduct
    {
        public int Operation(int value)
        {
            return value + 2;
        }
    }
}