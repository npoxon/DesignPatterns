using DesignPatterns.Creational.Helpers;

namespace DesignPatterns.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();
        
        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public ConcreteBuilder()
        {
            Reset();
        }
        
        private void Reset()
        {
            _product = new Product();
        }
        
        // All production steps work with the same product instance.
        public void BuildPartA()
        {
            _product.Add(Text.PartA);
        }
        
        public void BuildPartB()
        {
            _product.Add(Text.PartB);
        }
        
        public void BuildPartC()
        {
            _product.Add(Text.PartC);
        }
        
        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Product GetProduct()
        {
            var result = _product;

            Reset();

            return result;
        }
    }
}