using System;
using System.Collections;

namespace Observer.Pull_Pattern
{
    public abstract class Subject
    {
        protected ArrayList _observers = new ArrayList();

        public abstract string State { get; set; }

        public abstract void Notify();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
    }

    public class ConcreteSubject : Subject
    {
        public override string State { get; set; }

        public override void Notify()
        {
            Console.WriteLine("ConcreteSubject: notifying subscribed observers.");

            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private string _observerState;

        private readonly ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public override void Update()
        {
            Console.WriteLine("ConcreteObserver: updated.");

            _observerState = _subject.State;
        }
    }
}
