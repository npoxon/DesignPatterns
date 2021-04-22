namespace DesignPatterns.Behavioral.Command
{
    // Some commands can implement simple operations on their own.
    public class SimpleCommand : ICommand
    {
        private readonly string _payload;

        public SimpleCommand(string payload)
        {
            _payload = payload;
        }

        public string Execute()
        {
            return _payload;
        }
    }
}