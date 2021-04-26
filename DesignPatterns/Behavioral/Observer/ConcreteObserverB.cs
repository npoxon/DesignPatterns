namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteObserverB : IObserver
    {
        public int Update(ISubject subject)
        {
            var reactions = 0;
            if (((Subject) subject).State == 0 || ((Subject) subject).State >= 2)
            {
                reactions++;
            }

            return reactions;
        }
    }
}