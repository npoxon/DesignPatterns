using DesignPatterns.Behavioral.Helpers;

namespace DesignPatterns.Behavioral.Template
{
    // The Abstract Class defines a template method that contains a skeleton of
    // some algorithm, composed of calls to (usually) abstract primitive
    // operations.
    //
    // Concrete subclasses should implement these operations, but leave the
    // template method itself intact.
    public abstract class AbstractClass
    {
        private string _text = string.Empty;

        // The template method defines the skeleton of an algorithm.
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperations1();
            BaseOperation2();
            Hook1();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        // These operations already have implementations.
        private void BaseOperation1()
        {
            _text += BehavioralText.BaseOperation1;
        }

        private void BaseOperation2()
        {
            _text += BehavioralText.BaseOperation2;
        }

        private void BaseOperation3()
        {
            _text += BehavioralText.BaseOperation3;
        }
        
        // These operations have to be implemented in subclasses.
        protected abstract string RequiredOperations1();

        protected abstract string RequiredOperation2();
        
        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }

        public string GetText()
        {
            return _text;
        }
    }

}