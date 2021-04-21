namespace DesignPatterns.Creational.Factory
{
    // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method.
    public abstract class Creator
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        protected abstract IProduct FactoryMethod();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public int SomeOperation(int value)
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            return product.Operation(value);
        }
    }

    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
}