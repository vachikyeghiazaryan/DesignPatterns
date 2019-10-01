using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Observer.Push_Pattern
{
    public abstract class Subject
    {
        protected List<Observer> _observers = new List<Observer>();
        
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
        private string _state;

        public override void Notify()
        {
            Console.WriteLine("ConcreteSubject: notifying subscribed observers");

            foreach (var observer in _observers)
            {
                observer.Notify(_state);
            }
            Console.WriteLine();
        }
    }

    public abstract class Observer
    {
        public abstract void Notify(string state);
    }

    public class ConcreteObserver : Observer
    {
        private string _observerState;
        private readonly ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public override void Notify(string state)
        {
            Console.WriteLine("ConcreteObserver: notification received");
            _observerState = state;
        }
    }
}
