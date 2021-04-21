namespace DesignPatterns.Creational.Factory
{
    public class ConcreteCreatorThatAdds2 : Creator
    {
        protected override IProduct FactoryMethod()
        {
            return new ConcreteProductThatAdds2();
        }
    }
}