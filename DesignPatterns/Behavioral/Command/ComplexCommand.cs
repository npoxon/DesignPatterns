namespace DesignPatterns.Behavioral.Command
{
    // However, some commands can delegate more complex operations to other
    // objects, called "receivers."
    public class ComplexCommand : ICommand
    {
        // Context data, required for launching the receiver's methods.
        private readonly string _a;
        private readonly string _b;
        private readonly Receiver _receiver;

        // Complex commands can accept one or several receiver objects along
        // with any context data via the constructor.
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        // Commands can delegate to any methods of a receiver.
        public string Execute()
        {
            _receiver.DoSomething(_a);
            return _receiver.DoSomethingElse(_b);
        }
    }
}