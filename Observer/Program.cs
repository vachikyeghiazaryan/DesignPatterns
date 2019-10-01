using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            PushPattern();

            Console.WriteLine();

            PullPattern();
        }

        static void PushPattern()
        {
            var subject = new Push_Pattern.ConcreteSubject();

            subject.Attach(new Push_Pattern.ConcreteObserver(subject));
            subject.Attach(new Push_Pattern.ConcreteObserver(subject));

            subject.Notify();
        }

        static void PullPattern()
        {
            var subject = new Pull_Pattern.ConcreteSubject();
            
            subject.Attach(new Pull_Pattern.ConcreteObserver(subject));
            subject.Attach(new Pull_Pattern.ConcreteObserver(subject));

            subject.Notify();
        }
    }
}
