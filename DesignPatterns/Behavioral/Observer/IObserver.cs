namespace DesignPatterns.Behavioral.Observer
{
    public interface IObserver
    {
        // Receive update from subject
        int Update(ISubject subject);
    }

}