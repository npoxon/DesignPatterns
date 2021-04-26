using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.Behavioral.Observer
{
    // The Subject owns some important state and notifies observers when the
    // state changes.
    public class Subject : ISubject
    {
        private readonly Random _random;
        public Subject()
        {
            _random = new Random();
        }
        
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public int State { get; private set; } = -0;

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private readonly List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Usually, the subscription logic is only a fraction of what a Subject
        // can really do. Subjects commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public int SomeBusinessLogic()
        {
            State = _random.Next(0, 10);

            Thread.Sleep(15);
            
            Notify();
            
            return State;
        }
    }
}