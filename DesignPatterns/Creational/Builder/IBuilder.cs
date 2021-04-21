using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.Creational.Builder
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void BuildPartA();
        
        void BuildPartB();
        
        void BuildPartC();
    }
    
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
}