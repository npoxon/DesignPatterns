namespace DesignPatterns.Behavioral.Observer
{
    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    public class ConcreteObserverA : IObserver
    {
        public int Update(ISubject subject)
        {
            var reactions = 0;
            if (((Subject) subject).State < 3)
            {
                reactions++;
            }

            return reactions;
        }
    }
}