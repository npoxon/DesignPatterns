namespace DesignPatterns.Behavioral.State
{
    // The base State class declares methods that all Concrete State should
    // implement and also provides a backreference to the Context object,
    // associated with the State. This backreference can be used by States to
    // transition the Context to another State.
    public abstract class State
    {
        protected Context Context;

        public void SetContext(Context context)
        {
            Context = context;
        }

        public abstract string Handle1();

        public abstract string Handle2();
    }
}