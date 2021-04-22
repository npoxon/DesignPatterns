namespace DesignPatterns.Creational.Factory
{
    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface IProduct
    {
        int Operation(int value);
    }

    // Concrete Products provide various implementations of the Product
    // interface.
}