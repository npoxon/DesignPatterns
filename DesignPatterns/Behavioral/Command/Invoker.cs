namespace DesignPatterns.Behavioral.Command
{
    // The Invoker is associated with one or several commands. It sends a
    // request to the command.
    public class Invoker
    {
        private ICommand _onFinish;
        private ICommand _onStart;

        // Initialize commands.
        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a
        // command.
        public string DoSomethingImportant()
        {
            _onStart?.Execute();
            return _onFinish?.Execute();
        }
    }
}