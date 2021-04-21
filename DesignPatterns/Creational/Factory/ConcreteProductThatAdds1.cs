namespace DesignPatterns.Creational.Factory
{
    public class ConcreteProductThatAdds1 : IProduct
    {
        public int Operation(int value)
        {
            return value + 1;
        }
    }
}